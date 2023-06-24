using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	internal static class Creation
	{
		// Token: 0x0600018D RID: 397 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2D98E30", Offset = "0x2D97430", VA = "0x182D98E30")]
		internal static Blueprint GetBlueprintInstance(ref int activeBlueprintNum)
		{
			return null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2D990A0", Offset = "0x2D976A0", VA = "0x182D990A0")]
		internal static BlueprintFace GetFaceInstance(Blueprint blueprint, IArchetype archetype)
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600018F")]
		internal static IFaceVisual GetFaceVisualInstance<T>(BlueprintFace face) where T : MonoBehaviour, IFaceVisual
		{
			return null;
		}
	}
}
