using System;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006DA RID: 1754
	[Token(Token = "0x20006DA")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewTreeLinker")]
	public class ScrewTreeLinker : MonoBehaviour, IWorldLocatorStateCallback
	{
		// Token: 0x06002E54 RID: 11860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E54")]
		[Address(RVA = "0x344C1F0", Offset = "0x344A7F0", VA = "0x18344C1F0")]
		private void Awake()
		{
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x344C350", Offset = "0x344A950", VA = "0x18344C350")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x344C530", Offset = "0x344AB30", VA = "0x18344C530")]
		public void InitFromTreeTransform(Transform tree)
		{
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E57")]
		[Address(RVA = "0x344C5B0", Offset = "0x344ABB0", VA = "0x18344C5B0")]
		public void InitFromLocatorId(WorldLocatorId locatorId)
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E58")]
		[Address(RVA = "0x344C710", Offset = "0x344AD10", VA = "0x18344C710", Slot = "4")]
		private void StateChanged(WorldObjectState newState)
		{
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x344C840", Offset = "0x344AE40", VA = "0x18344C840")]
		public void DeserializeData(ScrewTreeLinker.SaveData data)
		{
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5A")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public ScrewTreeLinker.SaveData GetSerializedData()
		{
			return null;
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5B")]
		[Address(RVA = "0x344C860", Offset = "0x344AE60", VA = "0x18344C860")]
		public ScrewTreeLinker()
		{
		}

		// Token: 0x04002860 RID: 10336
		[Token(Token = "0x4002860")]
		[FieldOffset(Offset = "0x20")]
		private ScrewTreeLinker.SaveData _treeData;

		// Token: 0x020006DB RID: 1755
		[Token(Token = "0x20006DB")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x06002E5C RID: 11868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E5C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SaveData()
			{
			}

			// Token: 0x04002861 RID: 10337
			[Token(Token = "0x4002861")]
			[FieldOffset(Offset = "0x10")]
			public WorldLocatorId _locatorId;
		}
	}
}
