using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSuite.BackBonne.Domain.models.BankIntegration
{
    public class AccesUserAccount : Entity, IAggregateRoot
    {
        public AccesUserAccount(int? tB_ACCESS_USER_ACCOUNT_ID, int? nUM_CC, int? nUM_AGENCIA, string? aCCESS_USER, string? fXTRADING_USERID, string? fXTRADING_NAME)
        {
            TB_ACCESS_USER_ACCOUNT_ID = tB_ACCESS_USER_ACCOUNT_ID;
            NUM_CC = nUM_CC;
            NUM_AGENCIA = nUM_AGENCIA;
            ACCESS_USER = aCCESS_USER;
            FXTRADING_USERID = fXTRADING_USERID;
            FXTRADING_NAME = fXTRADING_NAME;
        }

        public int? TB_ACCESS_USER_ACCOUNT_ID { get; private set; }

        public int? NUM_CC { get; private set; }

        public int? NUM_AGENCIA { get; private set; }

        public string? ACCESS_USER { get; private set; }

        public string? FXTRADING_USERID { get; private set; }

        public string? FXTRADING_NAME { get; private set; }
    }
}
