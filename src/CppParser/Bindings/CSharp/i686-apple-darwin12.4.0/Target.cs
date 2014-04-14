//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace Parser
    {
        public enum ParserIntType
        {
            NoInt = 0,
            SignedChar = 1,
            UnsignedChar = 2,
            SignedShort = 3,
            UnsignedShort = 4,
            SignedInt = 5,
            UnsignedInt = 6,
            SignedLong = 7,
            UnsignedLong = 8,
            SignedLongLong = 9,
            UnsignedLongLong = 10
        }

        public unsafe partial class ParserTargetInfo : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 164)]
            public struct Internal
            {
                [FieldOffset(0)]
                internal Std.String ABI;

                [FieldOffset(12)]
                internal CppSharp.Parser.ParserIntType Char16Type;

                [FieldOffset(16)]
                internal CppSharp.Parser.ParserIntType Char32Type;

                [FieldOffset(20)]
                internal CppSharp.Parser.ParserIntType Int64Type;

                [FieldOffset(24)]
                internal CppSharp.Parser.ParserIntType IntMaxType;

                [FieldOffset(28)]
                internal CppSharp.Parser.ParserIntType IntPtrType;

                [FieldOffset(32)]
                internal CppSharp.Parser.ParserIntType SizeType;

                [FieldOffset(36)]
                internal CppSharp.Parser.ParserIntType UIntMaxType;

                [FieldOffset(40)]
                internal CppSharp.Parser.ParserIntType WCharType;

                [FieldOffset(44)]
                internal CppSharp.Parser.ParserIntType WIntType;

                [FieldOffset(48)]
                internal uint BoolAlign;

                [FieldOffset(52)]
                internal uint BoolWidth;

                [FieldOffset(56)]
                internal uint CharAlign;

                [FieldOffset(60)]
                internal uint CharWidth;

                [FieldOffset(64)]
                internal uint Char16Align;

                [FieldOffset(68)]
                internal uint Char16Width;

                [FieldOffset(72)]
                internal uint Char32Align;

                [FieldOffset(76)]
                internal uint Char32Width;

                [FieldOffset(80)]
                internal uint HalfAlign;

                [FieldOffset(84)]
                internal uint HalfWidth;

                [FieldOffset(88)]
                internal uint FloatAlign;

                [FieldOffset(92)]
                internal uint FloatWidth;

                [FieldOffset(96)]
                internal uint DoubleAlign;

                [FieldOffset(100)]
                internal uint DoubleWidth;

                [FieldOffset(104)]
                internal uint ShortAlign;

                [FieldOffset(108)]
                internal uint ShortWidth;

                [FieldOffset(112)]
                internal uint IntAlign;

                [FieldOffset(116)]
                internal uint IntWidth;

                [FieldOffset(120)]
                internal uint IntMaxTWidth;

                [FieldOffset(124)]
                internal uint LongAlign;

                [FieldOffset(128)]
                internal uint LongWidth;

                [FieldOffset(132)]
                internal uint LongDoubleAlign;

                [FieldOffset(136)]
                internal uint LongDoubleWidth;

                [FieldOffset(140)]
                internal uint LongLongAlign;

                [FieldOffset(144)]
                internal uint LongLongWidth;

                [FieldOffset(148)]
                internal uint PointerAlign;

                [FieldOffset(152)]
                internal uint PointerWidth;

                [FieldOffset(156)]
                internal uint WCharAlign;

                [FieldOffset(160)]
                internal uint WCharWidth;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfoC2Ev")]
                internal static extern void ctor_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfoC2ERKS1_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfoD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfo6getABIEv")]
                internal static extern global::System.IntPtr getABI_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfo6setABIEPKc")]
                internal static extern void setABI_0(global::System.IntPtr instance, global::System.IntPtr s);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            internal ParserTargetInfo(ParserTargetInfo.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserTargetInfo(ParserTargetInfo.Internal native)
                : this(&native)
            {
            }

            public ParserTargetInfo(global::System.IntPtr native, bool isInternalImpl = false)
            {
                __Instance = native;
            }

            public ParserTargetInfo()
            {
                __Instance = Marshal.AllocHGlobal(164);
                Internal.ctor_1(__Instance);
            }

            public ParserTargetInfo(CppSharp.Parser.ParserTargetInfo _0)
            {
                __Instance = Marshal.AllocHGlobal(164);
                var arg0 = _0 == (CppSharp.Parser.ParserTargetInfo) null ? global::System.IntPtr.Zero : _0.__Instance;
                Internal.cctor_2(__Instance, arg0);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Internal.dtor_0(__Instance);
                Marshal.FreeHGlobal(__Instance);
            }

            public string ABI
            {
                get
                {
                    var __ret = Internal.getABI_0(__Instance);
                    if (__ret == global::System.IntPtr.Zero) return null;
                    return Marshal.PtrToStringAnsi(__ret);
                }

                set
                {
                    var arg0 = Marshal.StringToHGlobalAnsi(value);
                    Internal.setABI_0(__Instance, arg0);
                    Marshal.FreeHGlobal(arg0);
                }
            }

            public CppSharp.Parser.ParserIntType Char16Type
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Char16Type;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Char16Type = value;
                }
            }

            public CppSharp.Parser.ParserIntType Char32Type
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Char32Type;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Char32Type = value;
                }
            }

            public CppSharp.Parser.ParserIntType Int64Type
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Int64Type;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Int64Type = value;
                }
            }

            public CppSharp.Parser.ParserIntType IntMaxType
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->IntMaxType;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->IntMaxType = value;
                }
            }

            public CppSharp.Parser.ParserIntType IntPtrType
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->IntPtrType;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->IntPtrType = value;
                }
            }

            public CppSharp.Parser.ParserIntType SizeType
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->SizeType;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->SizeType = value;
                }
            }

            public CppSharp.Parser.ParserIntType UIntMaxType
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->UIntMaxType;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->UIntMaxType = value;
                }
            }

            public CppSharp.Parser.ParserIntType WCharType
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->WCharType;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->WCharType = value;
                }
            }

            public CppSharp.Parser.ParserIntType WIntType
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->WIntType;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->WIntType = value;
                }
            }

            public uint BoolAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->BoolAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->BoolAlign = value;
                }
            }

            public uint BoolWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->BoolWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->BoolWidth = value;
                }
            }

            public uint CharAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->CharAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->CharAlign = value;
                }
            }

            public uint CharWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->CharWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->CharWidth = value;
                }
            }

            public uint Char16Align
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Char16Align;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Char16Align = value;
                }
            }

            public uint Char16Width
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Char16Width;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Char16Width = value;
                }
            }

            public uint Char32Align
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Char32Align;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Char32Align = value;
                }
            }

            public uint Char32Width
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Char32Width;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Char32Width = value;
                }
            }

            public uint HalfAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->HalfAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->HalfAlign = value;
                }
            }

            public uint HalfWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->HalfWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->HalfWidth = value;
                }
            }

            public uint FloatAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->FloatAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->FloatAlign = value;
                }
            }

            public uint FloatWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->FloatWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->FloatWidth = value;
                }
            }

            public uint DoubleAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->DoubleAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->DoubleAlign = value;
                }
            }

            public uint DoubleWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->DoubleWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->DoubleWidth = value;
                }
            }

            public uint ShortAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ShortAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ShortAlign = value;
                }
            }

            public uint ShortWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ShortWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ShortWidth = value;
                }
            }

            public uint IntAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->IntAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->IntAlign = value;
                }
            }

            public uint IntWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->IntWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->IntWidth = value;
                }
            }

            public uint IntMaxTWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->IntMaxTWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->IntMaxTWidth = value;
                }
            }

            public uint LongAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LongAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LongAlign = value;
                }
            }

            public uint LongWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LongWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LongWidth = value;
                }
            }

            public uint LongDoubleAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LongDoubleAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LongDoubleAlign = value;
                }
            }

            public uint LongDoubleWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LongDoubleWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LongDoubleWidth = value;
                }
            }

            public uint LongLongAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LongLongAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LongLongAlign = value;
                }
            }

            public uint LongLongWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LongLongWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LongLongWidth = value;
                }
            }

            public uint PointerAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->PointerAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->PointerAlign = value;
                }
            }

            public uint PointerWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->PointerWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->PointerWidth = value;
                }
            }

            public uint WCharAlign
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->WCharAlign;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->WCharAlign = value;
                }
            }

            public uint WCharWidth
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->WCharWidth;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->WCharWidth = value;
                }
            }
        }
    }
}