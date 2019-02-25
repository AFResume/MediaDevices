﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaDevices.WMDM
{
    [Guid("923E5249-8731-4c5b-9B1C-B8B60B6E46AF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IWMDeviceManager2 //: IWMDeviceManager // derive from IWMDeviceManager does not work and cause in an exception
    {
        //[MethodImpl(MethodImplOptions.InternalCall)]
        void GetRevision([Out] out uint pdwRevision);

        //[MethodImpl(MethodImplOptions.InternalCall)]
        void GetDeviceCount([Out] out uint pdwCount);

        ///[MethodImpl(MethodImplOptions.InternalCall)]
        void EnumDevices([Out, MarshalAs(UnmanagedType.Interface)] out IWMDMEnumDevice ppEnumDevice);

        void GetDeviceFromCanonicalName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszCanonicalName,
            [Out, MarshalAs(UnmanagedType.Interface)] out IWMDMDevice ppDevice);
        
        void EnumDevices2(
            [Out, MarshalAs(UnmanagedType.Interface)] out IWMDMEnumDevice ppEnumDevice);
        
        void Reinitialize();
        
    }
}