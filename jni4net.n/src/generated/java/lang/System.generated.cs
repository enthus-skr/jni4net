//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class System : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _arraycopy0;
        
        internal static global::net.sf.jni4net.jni.MethodId _currentTimeMillis1;
        
        internal static global::net.sf.jni4net.jni.MethodId _nanoTime2;
        
        internal static global::net.sf.jni4net.jni.MethodId _identityHashCode3;
        
        internal static global::net.sf.jni4net.jni.MethodId _exit4;
        
        internal static global::net.sf.jni4net.jni.MethodId _runFinalizersOnExit5;
        
        internal static global::net.sf.jni4net.jni.MethodId _setProperty6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperty7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperty8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSecurityManager9;
        
        internal static global::net.sf.jni4net.jni.MethodId _load10;
        
        internal static global::net.sf.jni4net.jni.MethodId _loadLibrary11;
        
        internal static global::net.sf.jni4net.jni.MethodId _mapLibraryName12;
        
        internal static global::net.sf.jni4net.jni.MethodId _clearProperty13;
        
        internal static global::net.sf.jni4net.jni.MethodId _gc14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperties15;
        
        internal static global::net.sf.jni4net.jni.MethodId _getenv16;
        
        internal static global::net.sf.jni4net.jni.MethodId _getenv17;
        
        internal static global::net.sf.jni4net.jni.MethodId _inheritedChannel18;
        
        internal static global::net.sf.jni4net.jni.MethodId _runFinalization19;
        
        internal static global::net.sf.jni4net.jni.MethodId _setErr20;
        
        internal static global::net.sf.jni4net.jni.MethodId _setIn21;
        
        internal static global::net.sf.jni4net.jni.MethodId _setOut22;
        
        internal static global::net.sf.jni4net.jni.MethodId _setProperties23;
        
        internal static global::net.sf.jni4net.jni.MethodId _setSecurityManager24;
        
        internal static global::net.sf.jni4net.jni.FieldId _in25;
        
        internal static global::net.sf.jni4net.jni.FieldId _out26;
        
        internal static global::net.sf.jni4net.jni.FieldId _err27;
        
        protected System(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.System.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/io/InputStream;")]
        public static global::java.io.InputStream @in {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.InputStream>(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.System.staticClass, global::java.lang.System._in25));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/io/PrintStream;")]
        public static global::java.io.PrintStream @out {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.PrintStream>(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.System.staticClass, global::java.lang.System._out26));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/io/PrintStream;")]
        public static global::java.io.PrintStream err {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.PrintStream>(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.System.staticClass, global::java.lang.System._err27));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.System.staticClass = @__class;
            global::java.lang.System._arraycopy0 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
            global::java.lang.System._currentTimeMillis1 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "currentTimeMillis", "()J");
            global::java.lang.System._nanoTime2 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "nanoTime", "()J");
            global::java.lang.System._identityHashCode3 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "identityHashCode", "(Ljava/lang/Object;)I");
            global::java.lang.System._exit4 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "exit", "(I)V");
            global::java.lang.System._runFinalizersOnExit5 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "runFinalizersOnExit", "(Z)V");
            global::java.lang.System._setProperty6 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getProperty7 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getProperty8 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getSecurityManager9 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "getSecurityManager", "()Ljava/lang/SecurityManager;");
            global::java.lang.System._load10 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "load", "(Ljava/lang/String;)V");
            global::java.lang.System._loadLibrary11 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
            global::java.lang.System._mapLibraryName12 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._clearProperty13 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._gc14 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "gc", "()V");
            global::java.lang.System._getProperties15 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "getProperties", "()Ljava/util/Properties;");
            global::java.lang.System._getenv16 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getenv17 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "getenv", "()Ljava/util/Map;");
            global::java.lang.System._inheritedChannel18 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
            global::java.lang.System._runFinalization19 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "runFinalization", "()V");
            global::java.lang.System._setErr20 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "setErr", "(Ljava/io/PrintStream;)V");
            global::java.lang.System._setIn21 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "setIn", "(Ljava/io/InputStream;)V");
            global::java.lang.System._setOut22 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "setOut", "(Ljava/io/PrintStream;)V");
            global::java.lang.System._setProperties23 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "setProperties", "(Ljava/util/Properties;)V");
            global::java.lang.System._setSecurityManager24 = @__env.GetStaticMethodID(global::java.lang.System.staticClass, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
            global::java.lang.System._in25 = @__env.GetStaticFieldID(global::java.lang.System.staticClass, "in", "Ljava/io/InputStream;");
            global::java.lang.System._out26 = @__env.GetStaticFieldID(global::java.lang.System.staticClass, "out", "Ljava/io/PrintStream;");
            global::java.lang.System._err27 = @__env.GetStaticFieldID(global::java.lang.System.staticClass, "err", "Ljava/io/PrintStream;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;ILjava/lang/Object;II)V")]
        public static void arraycopy(global::java.lang.Object par0, int par1, global::java.lang.Object par2, int par3, int par4) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._arraycopy0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public static long currentTimeMillis() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.System.staticClass, global::java.lang.System._currentTimeMillis1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public static long nanoTime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.System.staticClass, global::java.lang.System._nanoTime2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public static int identityHashCode(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.System.staticClass, global::java.lang.System._identityHashCode3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public static void exit(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._exit4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public static void runFinalizersOnExit(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._runFinalizersOnExit5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String setProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._setProperty6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String getProperty(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._getProperty7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String getProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._getProperty8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/SecurityManager;")]
        public static global::java.lang.Object getSecurityManager() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._getSecurityManager9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public static void load(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._load10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public static void loadLibrary(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._loadLibrary11, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String mapLibraryName(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._mapLibraryName12, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String clearProperty(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._clearProperty13, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void gc() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._gc14);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Properties;")]
        public static global::java.util.Properties getProperties() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.util.Properties>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._getProperties15));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String getenv(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._getenv16, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        public static global::java.util.Map getenv() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._getenv17));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/channels/Channel;")]
        public static global::java.io.Closeable inheritedChannel() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.io.Closeable>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.System.staticClass, global::java.lang.System._inheritedChannel18));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void runFinalization() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._runFinalization19);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public static void setErr(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setErr20, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/InputStream;)V")]
        public static void setIn(global::java.io.InputStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setIn21, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public static void setOut(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setOut22, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Properties;)V")]
        public static void setProperties(global::java.util.Properties par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setProperties23, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/SecurityManager;)V")]
        public static void setSecurityManager(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setSecurityManager24, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.System(@__env);
            }
        }
    }
    #endregion
}
