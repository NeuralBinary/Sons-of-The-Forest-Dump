using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	public interface IDetachedPlacementStructure
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000CE5 RID: 3301
		[Token(Token = "0x17000318")]
		ushort TypeID { [Token(Token = "0x6000CE5")] get; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000CE6 RID: 3302
		[Token(Token = "0x17000319")]
		bool IsOrientationFixed { [Token(Token = "0x6000CE6")] get; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000CE7 RID: 3303
		[Token(Token = "0x1700031A")]
		Transform transform { [Token(Token = "0x6000CE7")] get; }

		// Token: 0x06000CE8 RID: 3304
		[Token(Token = "0x6000CE8")]
		bool HasStructureAtDir(Directions dir);
	}
}
