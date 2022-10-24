﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.App.STLDashboardModel
{
    public class STLDashboard
    {
    }
    public class STLParty
    {
        public String PL_ID;
        public String PL_NM;
        public String PL_ADD;
        public String PL_TEL_NO;
        public String URL_STRMNG_NM;
        public String URL_STRMNG;
        public String APP_SHRING_DESC;
    }
    public class STLRequestValidator
    {
        public string Host;
        public string Username;
        public string Password;
    }

    public class HeadOffice
    {
        //Party List Information
        public string parmplid { get; set; }
        public string parmplnm { get; set; }
        public string parmpladd { get; set; }
        public string parmtelno { get; set; }

        public string parmplemladd { get; set; }

        //Group Information
        public string parmpgrpid { get; set; }
        public string parmpsncd { get; set; }
        public string parmpltclid { get; set; }


    }
    public class AgentHeadOffice : HeadOffice
    {
        
        //User Information
        public string parmusrfnm { get; set; }
        public string parmusrlnm { get; set; }
        public string parmusrmnm { get; set; }
        public string parmusrnm { get; set; }
        public string parmusrpsswrd { get; set; }
        public string parmaddrss { get; set; }
        //6
        public string parmusrmobno { get; set; }
        public string parmemladd { get; set; }
        public string parmuserid { get; set; }
    }
    public class PCSCO : AgentHeadOffice
    {
        public string parmurlstrmngnm { get; set; }
        public string parmurlstrmng { get; set; }
        public string parmapkurl { get; set; }
        public string parmapkupdturl { get; set; }
    }
    public class GROUPEVENT
    {
        public string PL_ID;
        public string PGRP_ID;
        public string Title;
        public string Description;
        public string Date;
        public string Time;
        public string Location;
        public string Process;
        public string Event;
    }

    public class LiveStreaming
    {
        public string LiveStreamUrl;
        public string LiveStreamDescription;
        public string Group;
        public string PL_ID;
        public string PGRP_ID;
    }
    public class GroupList
    {
        public string PL_ID;
        public string PGRP_ID;
    }

    public class Donation
    {
        public string PL_ID;
        public string PGRP_ID;
        public double Amount;
        public string Purpose;
        public string DateReceived;
        public string iUSR_ID;
        public string DonoID;
        public string OTP;
        public string MobileNo;
    }
    public class Sitio
    {
        public string Region;
        public string Province;
        public string Municipality;
        public string Brgy;
        public string SitioID;
        public string SitioName;
    }
    public class Barangay
    {
        public string IslandCode;
        public string Region;
        public string Province;
        public string Municipality;
        public string BarangayCode;
        public string BarangayName;
        public string MunicipalityCode;
        public string Code;
        public string Name;
        public string ID;
    }
    public class AcctStatistic
    {
        public string PGRP_ID;
        public string Reg;
        public string Prov;
        public string Mun;
        public string Brgy;
        public string Sitio;
        public int AgeFrom;
        public int AgeTo;

    }
    public class TextBlasting
    {
        public string MobileNumber;
        public string TextMessage;
    }
    public class IndividualText
    {
        public string MobileNumber;
        public string TextMessage;
    }
    public class GenerateBlasting
    {
        public string Prefix;
        public string TextMessage;
        public int FromNo;
        public int ToNo;
    }
    public class TextBlastingMemberAccount
    {
        public string AccntID;
        public string Row_Num;
        public string Row_Num_To;
        public string Search;
    }

    public class Memorandum
    {
        public string MemoId;
        public string BrgyCode;
        public string MemorandumNo;
        public string MemorandumURL;
        public string Attachment;
        public string Subject;
    }
    public class DocumentType
    {
        public string DocTypeID;
        public string DocTypeNM;
        public string BrgyCode;
        public int Category;
        public string DocContent;
        public string iDocRequirements;
    }
    public class BarangayOfficial 
    {
        public string Userid;
        public string BarangayPositionID;
        public string Committee;
        public string TermStart;
        public string TermEnd;
        public string RankNo;
        public string BrgyOfficialID;
    }
    public class Profile_Picture
    {
        public string PL_ID;
        public string PGRP_ID;
        public string Userid;
        public string ImageURL;
        public string ImageBase64;
    }
    public class RequestDocument
    {
        public string ReqDocID;
        public string DoctypeID;
        public string BusinessID;
        public string BusinessName;
        public string BusinessAddress;
        public string Purpose;
        public string Type;
        public string BusinessOwnerAddress;
        public string BusinessOwnerName;
        public string RequestorNM;
        public string RequestorID;
        public List<String >Attachment;
        public String iAttachments;
        public string CTCNo;
        public string ORNO;
        public string Amount;
        public string STATUS;
        public string ApplicationDate;
        public string URLAttachment;
        public string URL_DocPath;
        public string CategoryID;
        public string Category_Document;
        public string BizReport;
        public string IssuedDate;
        public string ControlNo;
        public string AppointmentDate;
        public string OTRDocumentType;
        public string isPaid;
        public string isFree;

    }
    public class Blotter
    {
        public string PL_ID;
        public string PGRP_ID;
        public string BarangayCaseNo;
        public string ComplainantsName;
        public string RespondentsName;
        public string RegionCode;
        public string ProvinceCode;
        public string MunicipalCode;
        public string BrgyCode;
        public string PurokOrSitio;
        public string BarangayCaptain;
        public string BarangaySecretary;
        public string Accusations;
        public string PlaceOfIncident;
        public string JsonStringAccomplice;
        public string DateTimeOfIncident;
        public string NarrativeOfIncident;
        public string DateCreated;
        public string ModifiedBy;
        public string DTModified;
        public string ReportPath;
        public string Docname;
        public string SummonDate;
    }

    public class HouseDetails
    {
        public string HouseId;
        public string HouseholdId;
        public string FamilyId;
        public string HouseholdUser;
        public string NewFamilyHead;
        public string FamilyMember;
        public string NewFamilyMember;
        public string HouseOwner;
        public string HouseClassification;
        public string SitioId;
        public string HouseholderRelationship;
        public string FamilyHeadRelationship;
        public string HomeAddress;
        public string CreatedBy;
    }

    public class PurposeDetails
    {
        public string PurposeID;
        public string PurposeDescription;
    }

    //public class Position
    //{
    //    public string JsonString;
    //}
    public class Position
    {
        public int PositionId;
        public string PL_ID;
        public string PGRP_ID;
        public string LOC_BRGY;
        public string Positionn;
        public int Category;
    }

    public class Religion
    {
        public string Code;
        public string Description;
    }

    public class CertificateTypeDetails
    {
        public string CertTypID;
        public string CertTypDescription;

    }
    public class BusinessOwnershipType
    {
        public string BusinessOwnershiptypeID;
        public string BusinessOwnershipDescription;
    }
    public class AppointDetails
    {
        public string JsonString;
        public string DateCreated;
    }

    public class BrgyCedula
    {
        public string CedulaId;
        public string RequestBy;
        public string RequestType;
        public string RequestPurpose;
        public string Birthdate;
        public string Gender;
        public string Address;
        public string Citizenship;
        public string CivilStatus;
        public decimal BCT;
        public decimal GEB;
        public decimal GEBTax;
        public decimal GEP;
        public decimal GEPTax;
        public decimal IRP;
        public decimal IRPTax;
        public decimal TotalTax;
        public decimal InterestRate;
        public decimal Interest;
        public decimal AmountPaid;
        public string ProcessBy;
        public string ProcessDate;
    }

    public class BrgyClearance
    {
        public string ClearanceNo;
        public string ControlNo;
        public string TypeofClearance;
        public string Purpose;
        public string ORNumber;
        public string AmountPaid;
        public string DocStamp;
        public int EnableCommunityTax;
        public string CTCNo;
        public string CTCIssuedAt;
        public string CTCIssuedOn;
        public string DocumentID;
        public string UserID;
        public string Requestor;

        public string IssuedDate;
        public string ExpiryDate;
        public int MosValidity;
    }
    public class BrgyBusinessClearance
    {
        public string BusinessClearanceID;
        public string ControlNo;
        public string BusinessID;
        public string ORNumber;
        public string AmountPaid;
        public string DocStamp;
        public int EnableCommunityTax;
        public string CTCNo;
        public string CTCIssuedAt;
        public string CTCIssuedOn;
        public string OwnerID;
        public string IssuedDate;
        public string ExpiryDate;
        public int MosValidity;
        public string VerifiedBy;
        public string CertifiedBy;
    }
}

