using System;
using System.Runtime.InteropServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	public static class ItemUtils
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x2F3E790", Offset = "0x2F3CD90", VA = "0x182F3E790")]
		public static void DropNearTarget(ElementProfile profile, TargetInfo targetInfo)
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x2F3EBA0", Offset = "0x2F3D1A0", VA = "0x182F3EBA0")]
		public static GameObject SpawnPickup(Transform from, ItemData item, [Optional] Vector3 torque, [Optional] Vector3 force, ForceMode forceMode = ForceMode.Impulse)
		{
			return null;
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x2F3ED10", Offset = "0x2F3D310", VA = "0x182F3ED10")]
		public static GameObject SpawnPickup(Vector3 worldPos, Quaternion worldRot, ItemData item, [Optional] Vector3 torque, [Optional] Vector3 force, ForceMode forceMode = ForceMode.Impulse, [Optional] IProtocolToken boltToken)
		{
			return null;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x2F3F0B0", Offset = "0x2F3D6B0", VA = "0x182F3F0B0")]
		public static void CheckSpawnFailedPlacementPickup(IConstructionModule module, ItemData targetItem, TargetInfo targetInfo, Transform actorMainTr)
		{
		}
	}
}
