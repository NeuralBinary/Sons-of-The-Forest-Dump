using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Rendering
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[AddComponentMenu("Sons/Items/Core/ExcludeRenderableFrom")]
	public class ExcludeRenderableFrom : MonoBehaviour
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA95840", Offset = "0xA93E40", VA = "0x180A95840")]
		public bool IsExcluded(ExcludeRenderableFrom.Type type)
		{
			return default(bool);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ExcludeRenderableFrom()
		{
		}

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ExcludeRenderableFrom.Type _excludedFrom;

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		[Flags]
		public enum Type
		{
			// Token: 0x040001B4 RID: 436
			[Token(Token = "0x40001B4")]
			Sheen = 1,
			// Token: 0x040001B5 RID: 437
			[Token(Token = "0x40001B5")]
			Collision = 2,
			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			Outline = 4,
			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			GreyOut = 8,
			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			ExcludeFromHideArms = 16
		}
	}
}
