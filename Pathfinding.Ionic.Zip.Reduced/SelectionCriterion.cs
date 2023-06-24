using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	internal abstract class SelectionCriterion
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected SelectionCriterion()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		internal virtual bool Verbose
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600005D RID: 93
		[Token(Token = "0x600005D")]
		internal abstract bool Evaluate(string filename);

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("SelectorTrace")]
		protected static void CriterionTrace(string format, params object[] args)
		{
		}

		// Token: 0x0600005F RID: 95
		[Token(Token = "0x600005F")]
		internal abstract bool Evaluate(ZipEntry entry);
	}
}
