using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	public struct DSP_DESCRIPTION
	{
		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x8")]
		public char[] name;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x10")]
		public uint version;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x50")]
		public int numparameters;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
}
