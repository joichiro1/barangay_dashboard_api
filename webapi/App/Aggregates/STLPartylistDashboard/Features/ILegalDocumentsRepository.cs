﻿using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.App.Aggregates.Common;
using webapi.App.RequestModel.AppRecruiter;
using Comm.Commons.Extensions;
using webapi.Commons.AutoRegister;
using webapi.App.Model.User;
using webapi.App.Aggregates.Common.Dto;
using webapi.App.Aggregates.SubscriberAppAggregate.Common;
using System.Globalization;
using webapi.App.RequestModel.Common;

namespace webapi.App.Aggregates.STLPartylistDashboard.Features
{
    [Service.ITransient(typeof(LegalDocumentRepository))]
    public interface ILegalDocumentsRepository
    {
        Task<(Results result, String message, object formtab)> FormTabAsyn(LegalDocument req);
        Task<(Results result, object formtab)> Load_FormTab(LegalDocument req);
        Task<(Results result, String message)> Delete_FormTab(LegalDocument req);
        Task<(Results result, String message, object legaldoc)> LegalDocAsync(LegalDocument_Transaction req);
        Task<(Results result, object legaldoc)> Load_LegalDoc(LegalDocument_Transaction req);
        Task<(Results result, object legaldocdetails)> Load_LegalDocDetails(LegalDocument_Transaction req);
    }
    public class LegalDocumentRepository:ILegalDocumentsRepository
    {
        private readonly ISubscriber _identity;
        public readonly IRepository _repo;
        public STLAccount account { get { return _identity.AccountIdentity(); } }
        public LegalDocumentRepository(ISubscriber  identity, IRepository repo)
        {
            _identity = identity;
            _repo = repo;
        }

        public async Task<(Results result, String message, object formtab)> FormTabAsyn(LegalDocument req)
        {
            var results = _repo.DSpQueryMultiple($"spfn_FORMTAB0A", new Dictionary<string, object>()
            {
                {"parmplid",account.PL_ID },
                {"parmpgrpid",account.PGRP_ID },
                {"parmformtabid", req.FormTabID },
                {"parmtagline", req.Tagline },
                {"parmformtabdescription",req.FormTabDescription },
                {"parmoptrid",account.USR_ID }
            }).ReadSingleOrDefault();
            if (results != null)
            {
                var row = ((IDictionary<string, object>)results);
                string ResultCode = row["RESULT"].Str();
                if (ResultCode == "1")
                    return (Results.Success, "Succesfull save", results);
                else if (ResultCode == "2")
                    return (Results.Failed, "Description already Save.", null);
                else if (ResultCode == "0")
                    return (Results.Failed, "Check your Data, Please try again!", null);
            }
            return (Results.Null, null, null);
        }

        public async Task<(Results result, object formtab)> Load_FormTab(LegalDocument req)
        {
            var result = _repo.DSpQuery<dynamic>($"dbo.spfn_FORMTAB0C", new Dictionary<string, object>()
            {
                {"parmplid",account.PL_ID },
                {"parmpgrpid",account.PGRP_ID },
                {"parmtagline", req.Tagline }
            });
            if (result != null)
                return (Results.Success, result);
            return (Results.Null, null);
        }

        public async Task<(Results result, string message)> Delete_FormTab(LegalDocument req)
        {
            var results = _repo.DSpQueryMultiple($"spfn_FORMTAB0D", new Dictionary<string, object>()
            {
                {"parmplid",account.PL_ID },
                {"parmpgrpid",account.PGRP_ID },
                {"parmformtabid", req.FormTabID },
            }).ReadSingleOrDefault();
            if (results != null)
            {
                var row = ((IDictionary<string, object>)results);
                string ResultCode = row["RESULT"].Str();
                if (ResultCode == "1")
                    return (Results.Success, "Succesfull Delete");
                else if (ResultCode == "0")
                    return (Results.Failed, "Check your Data, Please try again!");
            }
            return (Results.Null, null);
        }

        public async Task<(Results result, string message, object legaldoc)> LegalDocAsync(LegalDocument_Transaction req)
        {
            var results = _repo.DSpQueryMultiple($"spfn_LGLDOC0A", new Dictionary<string, object>()
            {
                {"parmplid",account.PL_ID },
                {"parmpgrpid",account.PGRP_ID },
                {"parmlgldocid", req.LegalFormsID },
                {"parmcontrolno", req.LegalFormssControlNo },
                {"parmrequestor",req.Requestor },
                {"parmtemplatetype",req.TypeofTemplateID },
                {"parmtemplatedoc",req.TemplateID },
                {"parmorno",req.ORNumber },
                {"parmamountpaid",req.AmountPaid },
                {"parmtagline",req.itagline },
                {"parmoptrid",account.USR_ID }
            }).ReadSingleOrDefault();
            if (results != null)
            {
                var row = ((IDictionary<string, object>)results);
                string ResultCode = row["RESULT"].Str();
                if (ResultCode == "1")
                    return (Results.Success, "Succesfull save", results);
                else if (ResultCode == "2")
                    return (Results.Failed, "Legal Document O.R Number already Save.", null);
                else if (ResultCode == "0")
                    return (Results.Failed, "Check your Data, Please try again!", null);
            }
            return (Results.Null, null, null);
        }

        public async Task<(Results result, object legaldoc)> Load_LegalDoc(LegalDocument_Transaction req)
        {
            var result = _repo.DSpQuery<dynamic>($"dbo.spfn_LGLDOC0C", new Dictionary<string, object>()
            {
                {"parmplid",account.PL_ID },
                {"parmpgrpid",account.PGRP_ID },
                {"parmrequestor", req.Requestor },
                {"parmtemplatetype", req.TypeofTemplateID },
                {"parmtemplatedoc", req.TemplateID },
                {"parmdatefrom", req.DateFrom },
                {"parmdateto", req.DateTo },
                {"parmsearch", req.Search }
            });
            if (result != null)
                return (Results.Success, SubscriberDto.GetLegalDocumentList(result, 100));
            return (Results.Null, null);
        }

        public async Task<(Results result, object legaldocdetails)> Load_LegalDocDetails(LegalDocument_Transaction req)
        {
            var result = _repo.DSpQuery<dynamic>($"dbo.spfn_LGLDOC0D", new Dictionary<string, object>()
            {
                {"parmplid",account.PL_ID },
                {"parmpgrpid",account.PGRP_ID },
                {"parmtemplateid", req.TemplateID },
                {"parmlegaldocid", req.LegalFormsID },
            });
            if (result != null)
                return (Results.Success, SubscriberDto.GetLegalDocumentDetailsList(result, 100));
            return (Results.Null, null);
        }
    }
}