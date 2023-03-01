using System;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007CE RID: 1998
	[Token(Token = "0x20007CE")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewTreeLinker")]
	public class ScrewTreeLinker : MonoBehaviour, IWorldLocatorStateCallback
	{
		// Token: 0x060034C0 RID: 13504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x2E982D0", Offset = "0x2E972D0", VA = "0x182E982D0")]
		private void Awake()
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x2E985C0", Offset = "0x2E975C0", VA = "0x182E985C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x2E98550", Offset = "0x2E97550", VA = "0x182E98550")]
		public void InitFromTreeTransform(Transform tree)
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x2E98470", Offset = "0x2E97470", VA = "0x182E98470")]
		public void InitFromLocatorId(WorldLocatorId locatorId)
		{
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x2E98770", Offset = "0x2E97770", VA = "0x182E98770", Slot = "4")]
		private void StateChanged(WorldObjectState newState)
		{
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x2E98450", Offset = "0x2E97450", VA = "0x182E98450")]
		public void DeserializeData(ScrewTreeLinker.SaveData data)
		{
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		public ScrewTreeLinker.SaveData GetSerializedData()
		{
			return null;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x2E98830", Offset = "0x2E97830", VA = "0x182E98830")]
		public ScrewTreeLinker()
		{
		}

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		[FieldOffset(Offset = "0x20")]
		private ScrewTreeLinker.SaveData _treeData;

		// Token: 0x020007CF RID: 1999
		[Token(Token = "0x20007CF")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x060034C8 RID: 13512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034C8")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public SaveData()
			{
			}

			// Token: 0x04002D7D RID: 11645
			[Token(Token = "0x4002D7D")]
			[FieldOffset(Offset = "0x10")]
			public WorldLocatorId _locatorId;
		}
	}
}
