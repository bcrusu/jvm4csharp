namespace jvm4csharp.JniApi
{
    internal enum JniResult
    {
        Ok,                 //success
        Err = -1,           //unknown error
        ErrDetached = -2,   //thread detached from the VM
        ErrVersion = -3,    //JNI version error
        ErrNomem = -4,      //not enough memory
        ErrExist = -5,      //VM already created
        ErrInval = -6       //invalid argument
    }
}