//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class JavaExceptions : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _throwBack0;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass2;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait3;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait4;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait5;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals6;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify7;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll8;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString9;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor10;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JavaExceptions() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::net.sf.jni4net.tested.JavaExceptions.staticClass, global::net.sf.jni4net.tested.JavaExceptions.@__ctor10, this);
        }
        
        protected JavaExceptions(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JavaExceptions.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.JavaExceptions.staticClass = @__class;
            global::net.sf.jni4net.tested.JavaExceptions._throwBack0 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "throwBack", "()V");
            global::net.sf.jni4net.tested.JavaExceptions._hashCode1 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "hashCode", "()I");
            global::net.sf.jni4net.tested.JavaExceptions._getClass2 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "getClass", "()Ljava/lang/Class;");
            global::net.sf.jni4net.tested.JavaExceptions._wait3 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "wait", "()V");
            global::net.sf.jni4net.tested.JavaExceptions._wait4 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "wait", "(JI)V");
            global::net.sf.jni4net.tested.JavaExceptions._wait5 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "wait", "(J)V");
            global::net.sf.jni4net.tested.JavaExceptions._equals6 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::net.sf.jni4net.tested.JavaExceptions._notify7 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "notify", "()V");
            global::net.sf.jni4net.tested.JavaExceptions._notifyAll8 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "notifyAll", "()V");
            global::net.sf.jni4net.tested.JavaExceptions._toString9 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "toString", "()Ljava/lang/String;");
            global::net.sf.jni4net.tested.JavaExceptions.@__ctor10 = @__env.GetMethodID(global::net.sf.jni4net.tested.JavaExceptions.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void throwBack() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaExceptions._throwBack0);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::net.sf.jni4net.tested.JavaExceptions._hashCode1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JavaExceptions._getClass2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaExceptions._wait3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaExceptions._wait4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaExceptions._wait5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JavaExceptions._equals6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaExceptions._notify7);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaExceptions._notifyAll8);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.jni4net.tested.JavaExceptions._toString9));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.JavaExceptions(@__env);
            }
        }
    }
    #endregion
}
