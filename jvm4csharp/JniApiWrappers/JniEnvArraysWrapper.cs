using System;
using System.Diagnostics;
using jvm4csharp.ArrayUtils;
using jvm4csharp.JniApi;

namespace jvm4csharp.JniApiWrappers
{
    internal class JniEnvArraysWrapper
    {
        private readonly JniEnvWrapper _jniEnvWrapper;

        private JniNativeInterfaceSig.Arrays.ByteArray.NewByteArray _newByteArray;
        private JniNativeInterfaceSig.Arrays.ObjectArray.NewObjectArray _newObjectArray;
        private JniNativeInterfaceSig.Arrays.BooleanArray.NewBooleanArray _newBooleanArray;
        private JniNativeInterfaceSig.Arrays.IntArray.NewIntArray _newIntArray;
        private JniNativeInterfaceSig.Arrays.ShortArray.NewShortArray _newShortArray;
        private JniNativeInterfaceSig.Arrays.FloatArray.NewFloatArray _newFloatArray;
        private JniNativeInterfaceSig.Arrays.CharArray.NewCharArray _newCharArray;
        private JniNativeInterfaceSig.Arrays.DoubleArray.NewDoubleArray _newDoubleArray;
        private JniNativeInterfaceSig.Arrays.LongArray.NewLongArray _newLongArray;
        private JniNativeInterfaceSig.Arrays.BooleanArray.GetBooleanArrayRegion _getBooleanArrayRegion;
        private JniNativeInterfaceSig.Arrays.ByteArray.GetByteArrayRegion _getByteArrayRegion;
        private JniNativeInterfaceSig.Arrays.CharArray.GetCharArrayRegion _getCharArrayRegion;
        private JniNativeInterfaceSig.Arrays.ShortArray.GetShortArrayRegion _getShortArrayRegion;
        private JniNativeInterfaceSig.Arrays.LongArray.GetLongArrayRegion _getLongArrayRegion;
        private JniNativeInterfaceSig.Arrays.IntArray.GetIntArrayRegion _getIntArrayRegion;
        private JniNativeInterfaceSig.Arrays.FloatArray.GetFloatArrayRegion _getFloatArrayRegion;
        private JniNativeInterfaceSig.Arrays.DoubleArray.GetDoubleArrayRegion _getDoubleArrayRegion;
        private JniNativeInterfaceSig.Arrays.BooleanArray.SetBooleanArrayRegion _setBooleanArrayRegion;
        private JniNativeInterfaceSig.Arrays.ByteArray.SetByteArrayRegion _setByteArrayRegion;
        private JniNativeInterfaceSig.Arrays.CharArray.SetCharArrayRegion _setCharArrayRegion;
        private JniNativeInterfaceSig.Arrays.LongArray.SetLongArrayRegion _setLongArrayRegion;
        private JniNativeInterfaceSig.Arrays.ShortArray.SetShortArrayRegion _setShortArrayRegion;
        private JniNativeInterfaceSig.Arrays.IntArray.SetIntArrayRegion _setIntArrayRegion;
        private JniNativeInterfaceSig.Arrays.FloatArray.SetFloatArrayRegion _setFloatArrayRegion;
        private JniNativeInterfaceSig.Arrays.DoubleArray.SetDoubleArrayRegion _setDoubleArrayRegion;
        private JniNativeInterfaceSig.Arrays.GetArrayLength _getArrayLength;
        private JniNativeInterfaceSig.Arrays.ObjectArray.SetObjectArrayElement _setObjectArrayElement;
        private JniNativeInterfaceSig.Arrays.ObjectArray.GetObjectArrayElement _getObjectArrayElement;

        internal JniEnvArraysWrapper(JniEnvWrapper jniEnvWrapper)
        {
            Debug.Assert(jniEnvWrapper != null);
            _jniEnvWrapper = jniEnvWrapper;
            InitFunctions();
        }

        private unsafe void InitFunctions()
        {
            var jni = WrapperHelpers.GetJniNativeInterface(_jniEnvWrapper.JniEnvPtr);

            _getArrayLength = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.GetArrayLength>(jni.GetArrayLength);

            _newObjectArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ObjectArray.NewObjectArray>(jni.NewObjectArray);
            _setObjectArrayElement = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ObjectArray.SetObjectArrayElement>(jni.SetObjectArrayElement);
            _getObjectArrayElement = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ObjectArray.GetObjectArrayElement>(jni.GetObjectArrayElement);

            _newBooleanArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.BooleanArray.NewBooleanArray>(jni.NewBooleanArray);
            _newByteArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ByteArray.NewByteArray>(jni.NewByteArray);
            _newCharArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.CharArray.NewCharArray>(jni.NewCharArray);
            _newShortArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ShortArray.NewShortArray>(jni.NewShortArray);
            _newIntArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.IntArray.NewIntArray>(jni.NewIntArray);
            _newLongArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.LongArray.NewLongArray>(jni.NewLongArray);
            _newFloatArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.FloatArray.NewFloatArray>(jni.NewFloatArray);
            _newDoubleArray = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.DoubleArray.NewDoubleArray>(jni.NewDoubleArray);

            _getBooleanArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.BooleanArray.GetBooleanArrayRegion>(jni.GetBooleanArrayRegion);
            _getByteArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ByteArray.GetByteArrayRegion>(jni.GetByteArrayRegion);
            _getCharArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.CharArray.GetCharArrayRegion>(jni.GetCharArrayRegion);
            _getShortArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ShortArray.GetShortArrayRegion>(jni.GetShortArrayRegion);
            _getIntArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.IntArray.GetIntArrayRegion>(jni.GetIntArrayRegion);
            _getLongArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.LongArray.GetLongArrayRegion>(jni.GetLongArrayRegion);
            _getFloatArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.FloatArray.GetFloatArrayRegion>(jni.GetFloatArrayRegion);
            _getDoubleArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.DoubleArray.GetDoubleArrayRegion>(jni.GetDoubleArrayRegion);

            _setBooleanArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.BooleanArray.SetBooleanArrayRegion>(jni.SetBooleanArrayRegion);
            _setByteArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ByteArray.SetByteArrayRegion>(jni.SetByteArrayRegion);
            _setCharArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.CharArray.SetCharArrayRegion>(jni.SetCharArrayRegion);
            _setShortArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.ShortArray.SetShortArrayRegion>(jni.SetShortArrayRegion);
            _setIntArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.IntArray.SetIntArrayRegion>(jni.SetIntArrayRegion);
            _setLongArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.LongArray.SetLongArrayRegion>(jni.SetLongArrayRegion);
            _setFloatArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.FloatArray.SetFloatArrayRegion>(jni.SetFloatArrayRegion);
            _setDoubleArrayRegion = WrapperHelpers.GetDelegateForPointer<JniNativeInterfaceSig.Arrays.DoubleArray.SetDoubleArrayRegion>(jni.SetDoubleArrayRegion);
        }

        public int GetArrayLength(java.lang.Object array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            JvmContext.Current.ValidateProxyInstane(array);

            var length = _getArrayLength(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr);
            _jniEnvWrapper.Exceptions.CheckLastException();
            return length;
        }

        public java.lang.Object NewArray<TElement>(int length)
        {
            if (length < 0) throw new ArgumentException(nameof(length));

            var elementType = typeof(TElement);

            IntPtr arrayPtr;
            Type expectedProxyType;

            if (typeof(IJavaProxy).IsAssignableFrom(elementType))
            {
                expectedProxyType = typeof (ObjectArray<>).MakeGenericType(elementType);
                var clazz = _jniEnvWrapper.Classes.FindClass(elementType);
                arrayPtr = _newObjectArray(_jniEnvWrapper.JniEnvPtr, length, clazz.ProxyState.NativePtr, IntPtr.Zero);
                _jniEnvWrapper.Exceptions.CheckLastException();
            }
            else
            {
                if (elementType == typeof (int))
                {
                    expectedProxyType = typeof(IntArray);
                    arrayPtr = _newIntArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else if (elementType == typeof (bool))
                {
                    expectedProxyType = typeof(BooleanArray);
                    arrayPtr = _newBooleanArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else if (elementType == typeof (byte))
                {
                    expectedProxyType = typeof(ByteArray);
                    arrayPtr = _newByteArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else if (elementType == typeof (double))
                {
                    expectedProxyType = typeof(DoubleArray);
                    arrayPtr = _newDoubleArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else if (elementType == typeof (char))
                {
                    expectedProxyType = typeof(CharArray);
                    arrayPtr = _newCharArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else if (elementType == typeof (long))
                {
                    expectedProxyType = typeof(LongArray);
                    arrayPtr = _newLongArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else if (elementType == typeof (float))
                {
                    expectedProxyType = typeof(FloatArray);
                    arrayPtr = _newFloatArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else if (elementType == typeof (short))
                {
                    expectedProxyType = typeof(ShortArray);
                    arrayPtr = _newShortArray(_jniEnvWrapper.JniEnvPtr, length);
                }
                else
                    throw new ArgumentException($"Unsupported CLR type '{elementType}'.");
            }

            _jniEnvWrapper.Exceptions.CheckLastException();

            var proxy = _jniEnvWrapper.ProxyFactory.CreateProxy(expectedProxyType, arrayPtr);
            return (java.lang.Object)proxy;
        }

        public unsafe TElement[] GetArrayRegion<TElement>(java.lang.Object array, int startIndex, int length)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (startIndex < 0) throw new ArgumentException(nameof(startIndex));
            if (length <= 0) throw new ArgumentException(nameof(length));
            JvmContext.Current.ValidateProxyInstane(array);

            var elementType = typeof(TElement);
            Array result;

            if (elementType == typeof(bool))
            {
                var buffer = new byte[length];
                fixed (byte* addr = &buffer[0])
                    _getBooleanArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                _jniEnvWrapper.Exceptions.CheckLastException();

                result = JniBooleanValue.ToClrBool(buffer);
            }
            else
            {
                if (elementType == typeof(int))
                {
                    var buffer = new int[length];
                    fixed (int* addr = &buffer[0])
                        _getIntArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                    result = buffer;
                }
                else if (elementType == typeof(byte))
                {
                    var buffer = new byte[length];
                    fixed (byte* addr = &buffer[0])
                        _getByteArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                    result = buffer;
                }
                else if (elementType == typeof(double))
                {
                    var buffer = new double[length];
                    fixed (double* addr = &buffer[0])
                        _getDoubleArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                    result = buffer;
                }
                else if (elementType == typeof(char))
                {
                    var buffer = new char[length];
                    fixed (char* addr = &buffer[0])
                        _getCharArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                    result = buffer;
                }
                else if (elementType == typeof(long))
                {
                    var buffer = new long[length];
                    fixed (long* addr = &buffer[0])
                        _getLongArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                    result = buffer;
                }
                else if (elementType == typeof(float))
                {
                    var buffer = new float[length];
                    fixed (float* addr = &buffer[0])
                        _getFloatArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                    result = buffer;
                }
                else if (elementType == typeof(short))
                {
                    var buffer = new short[length];
                    fixed (short* addr = &buffer[0])
                        _getShortArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
                    result = buffer;
                }
                else
                    throw new ArgumentException($"Unsupported CLR type '{elementType}'.");

                _jniEnvWrapper.Exceptions.CheckLastException();
            }

            return (TElement[])result;
        }

        public unsafe void SetArrayRegion<TElement>(java.lang.Object array, int startIndex, int length, TElement[] buffer)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (startIndex < 0) throw new ArgumentException(nameof(startIndex));
            if (length <= 0) throw new ArgumentException(nameof(length));
            if (buffer.Length < length) throw new ArgumentException("Buffer length is too short.", nameof(buffer));
            JvmContext.Current.ValidateProxyInstane(array);

            var elementType = typeof(TElement);

            if (elementType == typeof(bool))
            {
                var tmpBuffer = JniBooleanValue.ToNativeBool((bool[])(object)buffer);
                fixed (byte* addr = &tmpBuffer[0])
                    _setBooleanArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);

            }
            else if (elementType == typeof(int))
            {
                var tmpBuffer = (int[])(object)buffer;
                fixed (int* addr = &tmpBuffer[0])
                    _setIntArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
            }
            else if (elementType == typeof(byte))
            {
                var tmpBuffer = (byte[])(object)buffer;
                fixed (byte* addr = &tmpBuffer[0])
                    _setByteArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
            }
            else if (elementType == typeof(double))
            {
                var tmpBuffer = (double[])(object)buffer;
                fixed (double* addr = &tmpBuffer[0])
                    _setDoubleArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
            }
            else if (elementType == typeof(char))
            {
                var tmpBuffer = (char[])(object)buffer;
                fixed (char* addr = &tmpBuffer[0])
                    _setCharArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
            }
            else if (elementType == typeof(long))
            {
                var tmpBuffer = (long[])(object)buffer;
                fixed (long* addr = &tmpBuffer[0])
                    _setLongArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
            }
            else if (elementType == typeof(float))
            {
                var tmpBuffer = (float[])(object)buffer;
                fixed (float* addr = &tmpBuffer[0])
                    _setFloatArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
            }
            else if (elementType == typeof(short))
            {
                var tmpBuffer = (short[])(object)buffer;
                fixed (short* addr = &tmpBuffer[0])
                    _setShortArrayRegion(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, startIndex, length, addr);
            }
            else
                throw new ArgumentException($"Unsupported CLR type '{elementType}'.");

            _jniEnvWrapper.Exceptions.CheckLastException();
        }

        public TElement GetObjectArrayElement<TElement>(java.lang.Object array, int index)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (index < 0) throw new ArgumentException(nameof(index));
            JvmContext.Current.ValidateProxyInstane(array);

            var objPtr = _getObjectArrayElement(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, index);
            _jniEnvWrapper.Exceptions.CheckLastException();

            var proxy = _jniEnvWrapper.ProxyFactory.CreateProxy(typeof(TElement), objPtr);
            return (TElement)proxy;
        }

        public void SetObjectArrayElement(java.lang.Object array, int index, IJavaObject element)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (index < 0) throw new ArgumentException(nameof(index));
            JvmContext.Current.ValidateProxyInstane(array);

            var elementProxy = (IJavaProxy) element;
            var elemPtr = elementProxy?.ProxyState.NativePtr ?? IntPtr.Zero;

            _setObjectArrayElement(_jniEnvWrapper.JniEnvPtr, array.ProxyState.NativePtr, index, elemPtr);
            _jniEnvWrapper.Exceptions.CheckLastException();
        }
    }
}