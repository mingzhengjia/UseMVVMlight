/**
* Namespace: UseMVVMlight.Model
*
* Functon： N/A
* Class Name： Student
*
* Ver Change Date; Responsible person; Change content;
* ───────────────────────────────────
* V0.01; 2016/10/8 14:55:35; JiaMZ;   first edition;
*
* Copyright (c) 2016 JiaMZ. All rights reserved.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MVVMlightCommand {
    public class Student:ViewModelBase {

        #region Constructors
        public Student() {
        }
        public Student(string name, string id, string sex ,string address) {
            this._name = name;
            this._sex = sex;
            this._stuID = id;
            this._address = address;
        }
        #endregion

        #region Members
        private string _name;
        private string _stuID;
        private string _sex;
        private string _address;


        #endregion

        #region Properties
        public string Name {
            get {
                return _name;
            }

            set {
                if (_name != value) {
                    _name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string StuID {
            get {
                return _stuID;
            }

            set {
                if (_stuID != value) {
                    _stuID = value;
                    RaisePropertyChanged("StuID");
                }
            }
        }

        public string Sex {
            get {
                return _sex;
            }

            set {
                if (_sex != value) {
                    _sex = value;
                    RaisePropertyChanged("Sex");
                }
            }
        }

        public string Address {
            get {
                return _address;
            }

            set {
                if (_address != value) {
                    _address = value;
                    RaisePropertyChanged("Address");
                }
            }
        }
        #endregion
    }
}
