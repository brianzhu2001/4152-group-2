/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SLNet {

using System;
using System.Runtime.InteropServices;

public class RakNetListUnsignedShort : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetListUnsignedShort(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakNetListUnsignedShort obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetListUnsignedShort() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SLikeNetPINVOKE.delete_RakNetListUnsignedShort(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ushort Get(uint position) {
    SWIGTYPE_p_unsigned_short ret = GetHelper(position);
    return UnsignedShortPointer.frompointer(ret).value();
  }

  public ushort Pop() {
    SWIGTYPE_p_unsigned_short ret = PopHelper();
    return UnsignedShortPointer.frompointer(ret).value();
  }
    public ushort this[int index]  
    {  
        get   
        {
            return Get((uint)index); // use indexto retrieve and return another value.    
        }  
        set   
        {
            Replace(value, value, (uint)index, "Not used", 0);// use index and value to set the value somewhere.   
        }  
    } 

  public RakNetListUnsignedShort() : this(SLikeNetPINVOKE.new_RakNetListUnsignedShort__SWIG_0(), true) {
  }

  public RakNetListUnsignedShort(RakNetListUnsignedShort original_copy) : this(SLikeNetPINVOKE.new_RakNetListUnsignedShort__SWIG_1(RakNetListUnsignedShort.getCPtr(original_copy)), true) {
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetListUnsignedShort CopyData(RakNetListUnsignedShort original_copy) {
    RakNetListUnsignedShort ret = new RakNetListUnsignedShort(SLikeNetPINVOKE.RakNetListUnsignedShort_CopyData(swigCPtr, RakNetListUnsignedShort.getCPtr(original_copy)), false);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private SWIGTYPE_p_unsigned_short GetHelper(uint position) {
    SWIGTYPE_p_unsigned_short ret = new SWIGTYPE_p_unsigned_short(SLikeNetPINVOKE.RakNetListUnsignedShort_GetHelper(swigCPtr, position), false);
    return ret;
  }

  public void Push(ushort input, string file, uint line) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Push(swigCPtr, input, file, line);
  }

  private SWIGTYPE_p_unsigned_short PopHelper() {
    SWIGTYPE_p_unsigned_short ret = new SWIGTYPE_p_unsigned_short(SLikeNetPINVOKE.RakNetListUnsignedShort_PopHelper(swigCPtr), false);
    return ret;
  }

  public void Insert(ushort input, uint position, string file, uint line) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Insert__SWIG_0(swigCPtr, input, position, file, line);
  }

  public void Insert(ushort input, string file, uint line) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Insert__SWIG_1(swigCPtr, input, file, line);
  }

  public void Replace(ushort input, ushort filler, uint position, string file, uint line) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Replace__SWIG_0(swigCPtr, input, filler, position, file, line);
  }

  public void Replace(ushort input) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Replace__SWIG_1(swigCPtr, input);
  }

  public void RemoveAtIndex(uint position) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_RemoveAtIndex(swigCPtr, position);
  }

  public void RemoveAtIndexFast(uint position) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_RemoveAtIndexFast(swigCPtr, position);
  }

  public void RemoveFromEnd(uint num) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_RemoveFromEnd__SWIG_0(swigCPtr, num);
  }

  public void RemoveFromEnd() {
    SLikeNetPINVOKE.RakNetListUnsignedShort_RemoveFromEnd__SWIG_1(swigCPtr);
  }

  public uint GetIndexOf(ushort input) {
    uint ret = SLikeNetPINVOKE.RakNetListUnsignedShort_GetIndexOf(swigCPtr, input);
    return ret;
  }

  public uint Size() {
    uint ret = SLikeNetPINVOKE.RakNetListUnsignedShort_Size(swigCPtr);
    return ret;
  }

  public void Clear(bool doNotDeallocateSmallBlocks, string file, uint line) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Clear(swigCPtr, doNotDeallocateSmallBlocks, file, line);
  }

  public void Preallocate(uint countNeeded, string file, uint line) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Preallocate(swigCPtr, countNeeded, file, line);
  }

  public void Compress(string file, uint line) {
    SLikeNetPINVOKE.RakNetListUnsignedShort_Compress(swigCPtr, file, line);
  }

}

}
