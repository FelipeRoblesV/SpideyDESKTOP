﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFBS.Presentacion.WSReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.modelo/", ConfigurationName="WSReference.MainWS")]
    public interface MainWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/recuperar_rol_loginRequest", ReplyAction="http://ws.modelo/MainWS/recuperar_rol_loginResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WFBS.Presentacion.WSReference.recuperar_rol_loginResponse recuperar_rol_login(WFBS.Presentacion.WSReference.recuperar_rol_loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/recuperar_rol_loginRequest", ReplyAction="http://ws.modelo/MainWS/recuperar_rol_loginResponse")]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.recuperar_rol_loginResponse> recuperar_rol_loginAsync(WFBS.Presentacion.WSReference.recuperar_rol_loginRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/Login_AdministradorRequest", ReplyAction="http://ws.modelo/MainWS/Login_AdministradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WFBS.Presentacion.WSReference.Login_AdministradorResponse Login_Administrador(WFBS.Presentacion.WSReference.Login_AdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/Login_AdministradorRequest", ReplyAction="http://ws.modelo/MainWS/Login_AdministradorResponse")]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.Login_AdministradorResponse> Login_AdministradorAsync(WFBS.Presentacion.WSReference.Login_AdministradorRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/Listar_Jefe_Funcionarios_desktopRequest", ReplyAction="http://ws.modelo/MainWS/Listar_Jefe_Funcionarios_desktopResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopResponse Listar_Jefe_Funcionarios_desktop(WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/Listar_Jefe_Funcionarios_desktopRequest", ReplyAction="http://ws.modelo/MainWS/Listar_Jefe_Funcionarios_desktopResponse")]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopResponse> Listar_Jefe_Funcionarios_desktopAsync(WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/recuperar_nombre_rolRequest", ReplyAction="http://ws.modelo/MainWS/recuperar_nombre_rolResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WFBS.Presentacion.WSReference.recuperar_nombre_rolResponse recuperar_nombre_rol(WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.modelo/MainWS/recuperar_nombre_rolRequest", ReplyAction="http://ws.modelo/MainWS/recuperar_nombre_rolResponse")]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.recuperar_nombre_rolResponse> recuperar_nombre_rolAsync(WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.modelo/")]
    public partial class clUsuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string passField;
        
        private int rolField;
        
        private int runField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
                this.RaisePropertyChanged("pass");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int rol {
            get {
                return this.rolField;
            }
            set {
                this.rolField = value;
                this.RaisePropertyChanged("rol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int run {
            get {
                return this.runField;
            }
            set {
                this.runField = value;
                this.RaisePropertyChanged("run");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.modelo/")]
    public partial class clListarJefeFuncionario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private string estadoField;
        
        private System.DateTime fechaNaacimientoField;
        
        private bool fechaNaacimientoFieldSpecified;
        
        private string nombreCompletoField;
        
        private string passwordField;
        
        private string perfilField;
        
        private string rolField;
        
        private string rutField;
        
        private string sexoField;
        
        private int telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime fechaNaacimiento {
            get {
                return this.fechaNaacimientoField;
            }
            set {
                this.fechaNaacimientoField = value;
                this.RaisePropertyChanged("fechaNaacimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaNaacimientoSpecified {
            get {
                return this.fechaNaacimientoFieldSpecified;
            }
            set {
                this.fechaNaacimientoFieldSpecified = value;
                this.RaisePropertyChanged("fechaNaacimientoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombreCompleto {
            get {
                return this.nombreCompletoField;
            }
            set {
                this.nombreCompletoField = value;
                this.RaisePropertyChanged("nombreCompleto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string perfil {
            get {
                return this.perfilField;
            }
            set {
                this.perfilField = value;
                this.RaisePropertyChanged("perfil");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string rol {
            get {
                return this.rolField;
            }
            set {
                this.rolField = value;
                this.RaisePropertyChanged("rol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string rut {
            get {
                return this.rutField;
            }
            set {
                this.rutField = value;
                this.RaisePropertyChanged("rut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string sexo {
            get {
                return this.sexoField;
            }
            set {
                this.sexoField = value;
                this.RaisePropertyChanged("sexo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="recuperar_rol_login", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class recuperar_rol_loginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.modelo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WFBS.Presentacion.WSReference.clUsuario user;
        
        public recuperar_rol_loginRequest() {
        }
        
        public recuperar_rol_loginRequest(WFBS.Presentacion.WSReference.clUsuario user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="recuperar_rol_loginResponse", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class recuperar_rol_loginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.modelo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public recuperar_rol_loginResponse() {
        }
        
        public recuperar_rol_loginResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Login_Administrador", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class Login_AdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.modelo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WFBS.Presentacion.WSReference.clUsuario user;
        
        public Login_AdministradorRequest() {
        }
        
        public Login_AdministradorRequest(WFBS.Presentacion.WSReference.clUsuario user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Login_AdministradorResponse", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class Login_AdministradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.modelo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public Login_AdministradorResponse() {
        }
        
        public Login_AdministradorResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listar_Jefe_Funcionarios_desktop", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class Listar_Jefe_Funcionarios_desktopRequest {
        
        public Listar_Jefe_Funcionarios_desktopRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Listar_Jefe_Funcionarios_desktopResponse", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class Listar_Jefe_Funcionarios_desktopResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.modelo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WFBS.Presentacion.WSReference.clListarJefeFuncionario[] @return;
        
        public Listar_Jefe_Funcionarios_desktopResponse() {
        }
        
        public Listar_Jefe_Funcionarios_desktopResponse(WFBS.Presentacion.WSReference.clListarJefeFuncionario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="recuperar_nombre_rol", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class recuperar_nombre_rolRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.modelo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WFBS.Presentacion.WSReference.clUsuario user;
        
        public recuperar_nombre_rolRequest() {
        }
        
        public recuperar_nombre_rolRequest(WFBS.Presentacion.WSReference.clUsuario user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="recuperar_nombre_rolResponse", WrapperNamespace="http://ws.modelo/", IsWrapped=true)]
    public partial class recuperar_nombre_rolResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.modelo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public recuperar_nombre_rolResponse() {
        }
        
        public recuperar_nombre_rolResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MainWSChannel : WFBS.Presentacion.WSReference.MainWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainWSClient : System.ServiceModel.ClientBase<WFBS.Presentacion.WSReference.MainWS>, WFBS.Presentacion.WSReference.MainWS {
        
        public MainWSClient() {
        }
        
        public MainWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WFBS.Presentacion.WSReference.recuperar_rol_loginResponse WFBS.Presentacion.WSReference.MainWS.recuperar_rol_login(WFBS.Presentacion.WSReference.recuperar_rol_loginRequest request) {
            return base.Channel.recuperar_rol_login(request);
        }
        
        public int recuperar_rol_login(WFBS.Presentacion.WSReference.clUsuario user) {
            WFBS.Presentacion.WSReference.recuperar_rol_loginRequest inValue = new WFBS.Presentacion.WSReference.recuperar_rol_loginRequest();
            inValue.user = user;
            WFBS.Presentacion.WSReference.recuperar_rol_loginResponse retVal = ((WFBS.Presentacion.WSReference.MainWS)(this)).recuperar_rol_login(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.recuperar_rol_loginResponse> WFBS.Presentacion.WSReference.MainWS.recuperar_rol_loginAsync(WFBS.Presentacion.WSReference.recuperar_rol_loginRequest request) {
            return base.Channel.recuperar_rol_loginAsync(request);
        }
        
        public System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.recuperar_rol_loginResponse> recuperar_rol_loginAsync(WFBS.Presentacion.WSReference.clUsuario user) {
            WFBS.Presentacion.WSReference.recuperar_rol_loginRequest inValue = new WFBS.Presentacion.WSReference.recuperar_rol_loginRequest();
            inValue.user = user;
            return ((WFBS.Presentacion.WSReference.MainWS)(this)).recuperar_rol_loginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WFBS.Presentacion.WSReference.Login_AdministradorResponse WFBS.Presentacion.WSReference.MainWS.Login_Administrador(WFBS.Presentacion.WSReference.Login_AdministradorRequest request) {
            return base.Channel.Login_Administrador(request);
        }
        
        public bool Login_Administrador(WFBS.Presentacion.WSReference.clUsuario user) {
            WFBS.Presentacion.WSReference.Login_AdministradorRequest inValue = new WFBS.Presentacion.WSReference.Login_AdministradorRequest();
            inValue.user = user;
            WFBS.Presentacion.WSReference.Login_AdministradorResponse retVal = ((WFBS.Presentacion.WSReference.MainWS)(this)).Login_Administrador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.Login_AdministradorResponse> WFBS.Presentacion.WSReference.MainWS.Login_AdministradorAsync(WFBS.Presentacion.WSReference.Login_AdministradorRequest request) {
            return base.Channel.Login_AdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.Login_AdministradorResponse> Login_AdministradorAsync(WFBS.Presentacion.WSReference.clUsuario user) {
            WFBS.Presentacion.WSReference.Login_AdministradorRequest inValue = new WFBS.Presentacion.WSReference.Login_AdministradorRequest();
            inValue.user = user;
            return ((WFBS.Presentacion.WSReference.MainWS)(this)).Login_AdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopResponse WFBS.Presentacion.WSReference.MainWS.Listar_Jefe_Funcionarios_desktop(WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest request) {
            return base.Channel.Listar_Jefe_Funcionarios_desktop(request);
        }
        
        public WFBS.Presentacion.WSReference.clListarJefeFuncionario[] Listar_Jefe_Funcionarios_desktop() {
            WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest inValue = new WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest();
            WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopResponse retVal = ((WFBS.Presentacion.WSReference.MainWS)(this)).Listar_Jefe_Funcionarios_desktop(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopResponse> WFBS.Presentacion.WSReference.MainWS.Listar_Jefe_Funcionarios_desktopAsync(WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest request) {
            return base.Channel.Listar_Jefe_Funcionarios_desktopAsync(request);
        }
        
        public System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopResponse> Listar_Jefe_Funcionarios_desktopAsync() {
            WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest inValue = new WFBS.Presentacion.WSReference.Listar_Jefe_Funcionarios_desktopRequest();
            return ((WFBS.Presentacion.WSReference.MainWS)(this)).Listar_Jefe_Funcionarios_desktopAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WFBS.Presentacion.WSReference.recuperar_nombre_rolResponse WFBS.Presentacion.WSReference.MainWS.recuperar_nombre_rol(WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest request) {
            return base.Channel.recuperar_nombre_rol(request);
        }
        
        public string recuperar_nombre_rol(WFBS.Presentacion.WSReference.clUsuario user) {
            WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest inValue = new WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest();
            inValue.user = user;
            WFBS.Presentacion.WSReference.recuperar_nombre_rolResponse retVal = ((WFBS.Presentacion.WSReference.MainWS)(this)).recuperar_nombre_rol(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.recuperar_nombre_rolResponse> WFBS.Presentacion.WSReference.MainWS.recuperar_nombre_rolAsync(WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest request) {
            return base.Channel.recuperar_nombre_rolAsync(request);
        }
        
        public System.Threading.Tasks.Task<WFBS.Presentacion.WSReference.recuperar_nombre_rolResponse> recuperar_nombre_rolAsync(WFBS.Presentacion.WSReference.clUsuario user) {
            WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest inValue = new WFBS.Presentacion.WSReference.recuperar_nombre_rolRequest();
            inValue.user = user;
            return ((WFBS.Presentacion.WSReference.MainWS)(this)).recuperar_nombre_rolAsync(inValue);
        }
    }
}
