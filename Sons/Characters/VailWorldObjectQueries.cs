using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000723 RID: 1827
	[Token(Token = "0x2000723")]
	[AddComponentMenu("Sons/Vail/VailWorldObjectQueries")]
	[Serializable]
	public class VailWorldObjectQueries : MonoBehaviour, IWorldQuerySystem
	{
		// Token: 0x0600309F RID: 12447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600309F")]
		[Address(RVA = "0x3479C70", Offset = "0x3478270", VA = "0x183479C70")]
		private void Start()
		{
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x3479D10", Offset = "0x3478310", VA = "0x183479D10", Slot = "4")]
		public bool GetClosestBush(Vector3 position, float radius, bool includeSmallBush, out Vector3 closestPos)
		{
			return default(bool);
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Token(Token = "0x60030A1")]
		[Address(RVA = "0x3479FB0", Offset = "0x34785B0", VA = "0x183479FB0", Slot = "5")]
		public bool GetClosestTree(Vector3 position, float radius, out Vector3 closestPos)
		{
			return default(bool);
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x60030A2")]
		[Address(RVA = "0x347A0D0", Offset = "0x34786D0", VA = "0x18347A0D0", Slot = "6")]
		public int GetTreeCount(Vector3 position, float radius)
		{
			return 0;
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailWorldObjectQueries()
		{
		}
	}
}
