using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public abstract class FloatingObjectBase : MonoBehaviour
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000DC RID: 220
		[Token(Token = "0x1700001C")]
		public abstract float ObjectWidth { [Token(Token = "0x60000DC")] get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000DD RID: 221
		[Token(Token = "0x1700001D")]
		public abstract bool InWater { [Token(Token = "0x60000DD")] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000DE RID: 222
		[Token(Token = "0x1700001E")]
		public abstract Vector3 Velocity { [Token(Token = "0x60000DE")] get; }

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected FloatingObjectBase()
		{
		}
	}
}
