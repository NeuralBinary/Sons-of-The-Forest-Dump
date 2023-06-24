using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[Flags]
	public enum PrefabKind
	{
		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		None = 0,
		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		InstanceInScene = 1,
		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		InstanceInPrefab = 2,
		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		Regular = 4,
		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		Variant = 8,
		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		NonPrefabInstance = 16,
		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		PrefabInstance = 3,
		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		PrefabAsset = 12,
		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		PrefabInstanceAndNonPrefabInstance = 19,
		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		All = 31
	}
}
