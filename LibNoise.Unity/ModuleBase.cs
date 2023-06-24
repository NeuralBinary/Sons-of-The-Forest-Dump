using System;
using System.Xml.Serialization;
using Il2CppDummyDll;
using UnityEngine;

namespace LibNoise
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public abstract class ModuleBase : IDisposable
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x207B8E0", Offset = "0x2079EE0", VA = "0x18207B8E0")]
		protected ModuleBase(int count)
		{
		}

		// Token: 0x17000006 RID: 6
		[Token(Token = "0x17000006")]
		public virtual ModuleBase this[int index]
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x207B970", Offset = "0x2079F70", VA = "0x18207B970", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x207BA50", Offset = "0x207A050", VA = "0x18207BA50", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000007")]
		protected ModuleBase[] Modules
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000008")]
		public int SourceModuleCount
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x207BB60", Offset = "0x207A160", VA = "0x18207BB60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		public abstract double GetValue(double x, double y, double z);

		// Token: 0x0600000F RID: 15 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x207BB70", Offset = "0x207A170", VA = "0x18207BB70")]
		public double GetValue(Vector3 coordinate)
		{
			return 0.0;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x207BB70", Offset = "0x207A170", VA = "0x18207BB70")]
		public double GetValue(ref Vector3 coordinate)
		{
			return 0.0;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000009")]
		public bool IsDisposed
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x207BBB0", Offset = "0x207A1B0", VA = "0x18207BBB0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x207BC50", Offset = "0x207A250", VA = "0x18207BC50", Slot = "8")]
		protected virtual bool Disposing()
		{
			return default(bool);
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		private ModuleBase[] _modules;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		[XmlIgnore]
		[NonSerialized]
		private bool _disposed;
	}
}
