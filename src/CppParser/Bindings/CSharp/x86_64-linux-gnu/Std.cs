// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CppSharp.Parser.CSharp")]

[assembly:InternalsVisibleTo("CppSharp.CppParser")]

namespace Std
{
}

namespace GnuCxx
{
}

namespace Std
{
    namespace ExceptionPtr
    {
        public unsafe partial class ExceptionPtr
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::System.IntPtr _M_exception_object;
            }
        }
    }
}

namespace Std
{
    public unsafe partial class Allocator : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcEC2Ev")]
            internal static extern void ctorc__N_std_S_allocator__C_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSaIcED2Ev")]
            internal static extern void dtorc__N_std_S_allocator__C_0(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.Allocator>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.Allocator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.Allocator(native.ToPointer(), skipVTables);
        }

        internal static global::Std.Allocator __CreateInstance(global::Std.Allocator.__Internal native, bool skipVTables = false)
        {
            return new global::Std.Allocator(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.Allocator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
            *(global::Std.Allocator.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocator(global::Std.Allocator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Allocator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Allocator()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::Std.Allocator.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            global::Std.Allocator.__Internal.ctorc__N_std_S_allocator__C_0((__Instance + __PointerAdjustment));
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.Allocator __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                global::Std.Allocator.__Internal.dtorc__N_std_S_allocator__C_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }
    }


    public unsafe partial class Rebind
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }
    }
}

namespace Std
{
    namespace VectorBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.VectorBase.VectorImpl.__Internal _M_impl;
        }


        public unsafe partial class VectorImpl
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }

    namespace Vector
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.VectorBase.VectorImpl.__Internal _M_impl;
        }
    }
}

namespace Std
{
    public unsafe partial class BitIterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr _M_p;

            [FieldOffset(8)]
            internal uint _M_offset;
        }
    }

    public unsafe partial class BitConstIterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr _M_p;

            [FieldOffset(8)]
            internal uint _M_offset;
        }
    }
}

namespace Std
{
    namespace Less
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
        }
    }
}

namespace Std
{
    public enum RbTreeColor : uint
    {
        S_red = 0,
        S_black = 1
    }

    namespace RbTree
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTree.RbTreeImpl.__Internal _M_impl;
        }


        public unsafe partial class ReuseOrAllocNode
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class AllocNode
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class RbTreeImpl
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }

    public unsafe partial class RbTreeNodeBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTreeColor _M_color;

            [FieldOffset(8)]
            internal global::System.IntPtr _M_parent;

            [FieldOffset(16)]
            internal global::System.IntPtr _M_left;

            [FieldOffset(24)]
            internal global::System.IntPtr _M_right;
        }
    }
}

namespace GnuCxx
{
}

namespace Std
{
    namespace Map
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.RbTree.__Internal _M_t;
        }


        public unsafe partial class ValueCompare
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}

namespace Std
{
}

namespace Std
{
}

public unsafe partial class MbstateT
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal int __count;

        [FieldOffset(4)]
        internal global::MbstateT._.__Internal __value;
    }

    public unsafe partial struct _
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint __wch;

            [FieldOffset(0)]
            internal fixed sbyte __wchb[4];
        }
    }
}

namespace Std
{
    public unsafe partial class CharTraits : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public unsafe partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSt11char_traitsIcE3eofEv")]
            internal static extern int Eofc__N_std_S_char_traits__C_0();
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.CharTraits>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.CharTraits __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.CharTraits(native.ToPointer(), skipVTables);
        }

        internal static global::Std.CharTraits __CreateInstance(global::Std.CharTraits.__Internal native, bool skipVTables = false)
        {
            return new global::Std.CharTraits(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.CharTraits.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.CharTraits.__Internal));
            *(global::Std.CharTraits.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CharTraits(global::Std.CharTraits.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CharTraits(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CharTraits()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::Std.CharTraits.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.CharTraits __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static int Eof()
        {
            var __ret = global::Std.CharTraits.__Internal.Eofc__N_std_S_char_traits__C_0();
            return __ret;
        }
    }
}

public unsafe partial class Timespec
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal long tv_sec;

        [FieldOffset(8)]
        internal long tv_nsec;
    }
}

public unsafe partial class Timeval
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal long tv_sec;

        [FieldOffset(8)]
        internal long tv_usec;
    }
}

public unsafe partial class PthreadInternalList
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::System.IntPtr __prev;

        [FieldOffset(8)]
        internal global::System.IntPtr __next;
    }
}

public unsafe partial struct PthreadMutexT
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadMutexT.PthreadMutexS.__Internal __data;

        [FieldOffset(0)]
        internal fixed sbyte __size[40];

        [FieldOffset(0)]
        internal long __align;
    }

    public unsafe partial class PthreadMutexS
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int __lock;

            [FieldOffset(4)]
            internal uint __count;

            [FieldOffset(8)]
            internal int __owner;

            [FieldOffset(12)]
            internal uint __nusers;

            [FieldOffset(16)]
            internal int __kind;

            [FieldOffset(20)]
            internal short __spins;

            [FieldOffset(22)]
            internal short __elision;

            [FieldOffset(24)]
            internal global::PthreadInternalList.__Internal __list;
        }
    }
}

public unsafe partial struct PthreadCondT
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadCondT._.__Internal __data;

        [FieldOffset(0)]
        internal fixed sbyte __size[48];

        [FieldOffset(0)]
        internal long __align;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int __lock;

            [FieldOffset(4)]
            internal uint __futex;

            [FieldOffset(8)]
            internal ulong __total_seq;

            [FieldOffset(16)]
            internal ulong __wakeup_seq;

            [FieldOffset(24)]
            internal ulong __woken_seq;

            [FieldOffset(32)]
            internal global::System.IntPtr __mutex;

            [FieldOffset(40)]
            internal uint __nwaiters;

            [FieldOffset(44)]
            internal uint __broadcast_seq;
        }
    }
}

public unsafe partial struct PthreadRwlockT
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::PthreadRwlockT._.__Internal __data;

        [FieldOffset(0)]
        internal fixed sbyte __size[56];

        [FieldOffset(0)]
        internal long __align;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int __lock;

            [FieldOffset(4)]
            internal uint __nr_readers;

            [FieldOffset(8)]
            internal uint __readers_wakeup;

            [FieldOffset(12)]
            internal uint __writer_wakeup;

            [FieldOffset(16)]
            internal uint __nr_readers_queued;

            [FieldOffset(20)]
            internal uint __nr_writers_queued;

            [FieldOffset(24)]
            internal int __writer;

            [FieldOffset(28)]
            internal int __shared;

            [FieldOffset(32)]
            internal sbyte __rwelision;

            [FieldOffset(33)]
            internal fixed byte __pad1[7];

            [FieldOffset(40)]
            internal ulong __pad2;

            [FieldOffset(48)]
            internal uint __flags;
        }
    }
}

public unsafe partial class PthreadUnwindBufT
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal fixed byte __cancel_jmp_buf[72];

        [FieldOffset(72)]
        internal void* __pad;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 72)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed long __cancel_jmp_buf[8];

            [FieldOffset(64)]
            internal int __mask_was_saved;
        }
    }
}

namespace Std
{
    public unsafe partial class BasicString : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public unsafe partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.AllocHider.__Internal _M_dataplus;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNSsD2Ev")]
            internal static extern void dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C_0(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Std-symbols", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="_ZNKSs5c_strEv")]
            internal static extern global::System.IntPtr CStrc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C_0(global::System.IntPtr instance);
        }

        public unsafe partial class AllocHider
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::System.IntPtr _M_p;
            }
        }

        public unsafe partial class RepBase
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal ulong _M_length;

                [FieldOffset(8)]
                internal ulong _M_capacity;

                [FieldOffset(16)]
                internal int _M_refcount;
            }
        }

        public unsafe partial class Rep
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal ulong _M_length;

                [FieldOffset(8)]
                internal ulong _M_capacity;

                [FieldOffset(16)]
                internal int _M_refcount;
            }
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Std.BasicString>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Std.BasicString __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Std.BasicString(native.ToPointer(), skipVTables);
        }

        internal static global::Std.BasicString __CreateInstance(global::Std.BasicString.__Internal native, bool skipVTables = false)
        {
            return new global::Std.BasicString(native, skipVTables);
        }

        private static void* __CopyValue(global::Std.BasicString.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Std.BasicString.__Internal));
            *(global::Std.BasicString.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private BasicString(global::Std.BasicString.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected BasicString(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Std.BasicString __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                global::Std.BasicString.__Internal.dtorc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C_0((__Instance + __PointerAdjustment));
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public string CStr
        {
            get
            {
                var __ret = global::Std.BasicString.__Internal.CStrc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C_0((__Instance + __PointerAdjustment));
                return Marshal.PtrToStringAnsi(__ret);
            }
        }
    }


    public unsafe partial class RepBase
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

    }

    public unsafe partial class Rep
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

    }

    public unsafe partial class AllocHider
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }
    }
}

public unsafe partial struct Wait
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal int w_status;

        [FieldOffset(0)]
        internal global::Wait._.__Internal __wait_terminated;

        [FieldOffset(0)]
        internal global::Wait.__.__Internal __wait_stopped;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint __w_termsig;

            [FieldOffset(0)]
            internal uint __w_coredump;

            [FieldOffset(1)]
            internal uint __w_retcode;

            [FieldOffset(2)]
            internal uint __;
        }
    }

    public unsafe partial class __
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint __w_stopval;

            [FieldOffset(1)]
            internal uint __w_stopsig;

            [FieldOffset(2)]
            internal uint __;
        }
    }
}

namespace Std
{
}

namespace Std
{
    public unsafe partial class SsoString
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.SsoString._.__Internal _;
        }

        public unsafe partial struct _
        {
            [StructLayout(LayoutKind.Explicit, Size = 32)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.SsoString.Str.__Internal _M_s;

                [FieldOffset(0)]
                internal fixed sbyte _M_bytes[32];
            }
        }

        public unsafe partial class Str
        {
            [StructLayout(LayoutKind.Explicit, Size = 32)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::System.IntPtr _M_p;

                [FieldOffset(8)]
                internal ulong _M_string_length;

                [FieldOffset(16)]
                internal fixed sbyte _M_local_buf[16];
            }
        }
    }
}

namespace Std
{
    public unsafe partial class UsesAlloc0
    {
        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Std.UsesAlloc0.Sink.__Internal _M_a;
        }

        public unsafe partial class Sink
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
}
