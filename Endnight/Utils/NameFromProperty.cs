using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utils
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class NameFromProperty : PropertyAttribute
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xA691E0", Offset = "0xA677E0", VA = "0x180A691E0")]
		public NameFromProperty(string nameProperty, int extraHeight = 0)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public string NameProperty
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public int ExtraHeight
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
