using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bnn
{
    class Member
    {
        private String _firtsName;
        private String _lastName;
        private String _avatar;
        private String _phone;
        private String _address;
        private String _introduction;
        private int _gender;
        private String _birthday;
        private String _email;
        private String _password;

        public string firtsName { get => _firtsName; set => _firtsName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string avatar { get => _avatar; set => _avatar = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string address { get => _address; set => _address = value; }
        public string introduction { get => _introduction; set => _introduction = value; }
        public int gender { get => _gender; set => _gender = value; }
        public string birthday { get => _birthday; set => _birthday = value; }
        public string email { get => _email; set => _email = value; }
        public string password { get => _password; set => _password = value; }
    }
}

