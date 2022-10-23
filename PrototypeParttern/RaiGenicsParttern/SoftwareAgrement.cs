using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrototypeParttern.RaiGenicsParttern
{
    public class SoftwareAgrement : IAgreement
    {
        private string _vendorName;
        private AgreementDto _agreementDto;
        private NonDisclosureAgreement _nonDisclosureAgreement;
        public SoftwareAgrement(string vendorName, NonDisclosureAgreement nonDisclosureAgreement)
        {
            _nonDisclosureAgreement = nonDisclosureAgreement;
            _vendorName = vendorName;

            Console.WriteLine("Fetching agreement clause from remote server");

            Thread.Sleep(4000);
            Console.Clear();
            AgreementClause clause = new AgreementClause();
            _agreementDto = clause.GetAgreementClause();
        }
        public IAgreement ShallowCopy()
        {
            //copy all cacs function cung nhu la cac bien
            return (IAgreement)this.MemberwiseClone();
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------Agreement Prototype--------");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine($"Vendor Name: {_vendorName}");
            Console.WriteLine($"NDA ID: {_nonDisclosureAgreement.Id}");


            Console.WriteLine($"\nDevelop Clause: {_agreementDto.DeveloperClause}");
            Console.WriteLine($"\nDevelop Clause: {_agreementDto.PostDeliveryClause}");
            Console.WriteLine($"\nDevelop Clause: {_agreementDto.ProjectTerminationClause}");


        }
    }
}
