using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Attributes
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	public class NameFromEnumIndex : PropertyAttribute
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public NameFromEnumIndex(Type enumType)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public Type EnumType
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
