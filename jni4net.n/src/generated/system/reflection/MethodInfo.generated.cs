//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class MethodInfo_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__MethodInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.MethodInfo))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.MethodInfo))]
    internal sealed partial class @__MethodInfo : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__MethodInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__MethodInfo.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__MethodInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReturnType", "ReturnType0", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReturnParameter", "ReturnParameter1", "()Lsystem/reflection/ParameterInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReturnTypeCustomAttributes", "ReturnTypeCustomAttributes2", "()Lsystem/reflection/ICustomAttributeProvider;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetBaseDefinition", "GetBaseDefinition3", "()Lsystem/reflection/MethodInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetGenericMethodDefinition", "GetGenericMethodDefinition4", "()Lsystem/reflection/MethodInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "MakeGenericMethod", "MakeGenericMethod5", "([Lsystem/Type;)Lsystem/reflection/MethodInfo;"));
            return methods;
        }
        
        private static global::System.IntPtr ReturnType0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MethodInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MethodInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Type>(@__env, @__real.ReturnType);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr ReturnParameter1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/reflection/ParameterInfo;
            // ()LSystem/Reflection/ParameterInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MethodInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MethodInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.ParameterInfo>(@__env, @__real.ReturnParameter);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr ReturnTypeCustomAttributes2(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/reflection/ICustomAttributeProvider;
            // ()LSystem/Reflection/ICustomAttributeProvider;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MethodInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MethodInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.Reflection.ICustomAttributeProvider>(@__env, @__real.ReturnTypeCustomAttributes);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetBaseDefinition3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/reflection/MethodInfo;
            // ()LSystem/Reflection/MethodInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MethodInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MethodInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodInfo>(@__env, @__real.GetBaseDefinition());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetGenericMethodDefinition4(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/reflection/MethodInfo;
            // ()LSystem/Reflection/MethodInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MethodInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MethodInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodInfo>(@__env, @__real.GetGenericMethodDefinition());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr MakeGenericMethod5(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr typeArguments) {
            // ([Lsystem/Type;)Lsystem/reflection/MethodInfo;
            // ([LSystem/Type;)LSystem/Reflection/MethodInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MethodInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MethodInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodInfo>(@__env, @__real.MakeGenericMethod(global::net.sf.jni4net.utils.Convertor.ArrayStrongJp2C<System.Type[]>(@__env, typeArguments)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__MethodInfo(@__env);
            }
        }
    }
    #endregion
}
