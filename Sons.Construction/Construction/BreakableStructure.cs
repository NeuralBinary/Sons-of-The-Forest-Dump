using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[AddComponentMenu("Sons/Construction/BreakableStructure")]
	public class BreakableStructure : MonoBehaviour
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2E37790", Offset = "0x2E35D90", VA = "0x182E37790")]
		public void OnBreakCollision(float force)
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2E37BB0", Offset = "0x2E361B0", VA = "0x182E37BB0")]
		public static void CheckBreakable(IBreakableStructure structure, out bool changed)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2E37E00", Offset = "0x2E36400", VA = "0x182E37E00")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BreakableStructure()
		{
		}

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;
	}
}
