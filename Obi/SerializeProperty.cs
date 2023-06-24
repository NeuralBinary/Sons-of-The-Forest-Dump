using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SerializeProperty : PropertyAttribute
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000148")]
		public string PropertyName
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public SerializeProperty(string propertyName)
		{
		}
	}
}
