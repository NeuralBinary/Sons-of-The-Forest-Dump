using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	[AttributeUsage(AttributeTargets.Field)]
	public class VisibleIf : MultiPropertyAttribute
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000149")]
		public string MethodName
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00004A3C File Offset: 0x00002C3C
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700014A")]
		public bool Negate
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x27F3E00", Offset = "0x27F2400", VA = "0x1827F3E00")]
		public VisibleIf(string methodName, bool negate = false)
		{
		}

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x28")]
		private MethodInfo eventMethodInfo;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x30")]
		private FieldInfo fieldInfo;
	}
}
