using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	[AddComponentMenu("Sons/Vail/VailWorldObjectQueries")]
	[Serializable]
	public class VailWorldObjectQueries : MonoBehaviour, IWorldQuerySystem
	{
		// Token: 0x060036C6 RID: 14022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x2EBEDE0", Offset = "0x2EBDDE0", VA = "0x182EBEDE0")]
		private void Start()
		{
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x2EBEAE0", Offset = "0x2EBDAE0", VA = "0x182EBEAE0", Slot = "4")]
		public bool GetClosestBush(Vector3 position, float radius, bool includeSmallBush, out Vector3 closestPos)
		{
			return default(bool);
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x2EBEC20", Offset = "0x2EBDC20", VA = "0x182EBEC20", Slot = "5")]
		public bool GetClosestTree(Vector3 position, float radius, out Vector3 closestPos)
		{
			return default(bool);
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x2EBED40", Offset = "0x2EBDD40", VA = "0x182EBED40", Slot = "6")]
		public int GetTreeCount(Vector3 position, float radius)
		{
			return default(int);
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public VailWorldObjectQueries()
		{
		}
	}
}
