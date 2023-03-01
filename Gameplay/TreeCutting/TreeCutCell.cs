using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006E2 RID: 1762
	[Token(Token = "0x20006E2")]
	[Serializable]
	public class TreeCutCell : ISerializationCallbackReceiver
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A4")]
		public GameObject gameObject
		{
			[Token(Token = "0x6002D26")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
		public bool GetRemovedState()
		{
			return default(bool);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x6002D28")]
		[Address(RVA = "0x5CEF60", Offset = "0x5CDF60", VA = "0x1805CEF60")]
		public int GetFrontCellId()
		{
			return default(int);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x6002D29")]
		[Address(RVA = "0x66D280", Offset = "0x66C280", VA = "0x18066D280")]
		public int GetBackCellId()
		{
			return default(int);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0x2E16CD0", Offset = "0x2E15CD0", VA = "0x182E16CD0")]
		public void InitializeBlock(Material blockMaterial)
		{
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2B")]
		[Address(RVA = "0x5A85D0", Offset = "0x5A75D0", VA = "0x1805A85D0")]
		public void SetCellGameObject(GameObject cellObj)
		{
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0x92EF90", Offset = "0x92DF90", VA = "0x18092EF90")]
		public void SetId(int id)
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x2E180B0", Offset = "0x2E170B0", VA = "0x182E180B0")]
		public void UpdateMesh(IEnumerable<TreeCutMesh> cutMeshes)
		{
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x2E17E30", Offset = "0x2E16E30", VA = "0x182E17E30")]
		private void RingModulation(int id, int rings, int segments, int layerPointCount, out int ringSegments, out int modulationValue, out int innerId)
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x5CEF80", Offset = "0x5CDF80", VA = "0x1805CEF80")]
		private void PassFrontId(int Id)
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x2E17020", Offset = "0x2E16020", VA = "0x182E17020")]
		private bool IsOuter(int layerPointCount, int segments)
		{
			return default(bool);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x2E18400", Offset = "0x2E17400", VA = "0x182E18400")]
		public void WakeOuter()
		{
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x2E16390", Offset = "0x2E15390", VA = "0x182E16390")]
		public void EvaluateNeighbors(int layers, int rings, int segments, int ccount, int lcount, TreeCutManager manager)
		{
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D33")]
		[Address(RVA = "0x2E17110", Offset = "0x2E16110", VA = "0x182E17110")]
		public void OnBlockCollisionEvent()
		{
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D34")]
		[Address(RVA = "0x2E17300", Offset = "0x2E16300", VA = "0x182E17300")]
		public void OnBlockRemoved(int Id)
		{
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D35")]
		[Address(RVA = "0x2E17E10", Offset = "0x2E16E10", VA = "0x182E17E10")]
		public void ResetCell()
		{
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x2E17490", Offset = "0x2E16490", VA = "0x182E17490")]
		public void OnFrontRemoved(TreeCutManager manager)
		{
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x2E16380", Offset = "0x2E15380", VA = "0x182E16380")]
		private void Awaken()
		{
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3A")]
		[Address(RVA = "0x2E17710", Offset = "0x2E16710", VA = "0x182E17710")]
		public void Remove()
		{
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0x2E176C0", Offset = "0x2E166C0", VA = "0x182E176C0")]
		public void RemoveSimple()
		{
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x2E17640", Offset = "0x2E16640", VA = "0x182E17640")]
		public void RemoveDelayed()
		{
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
		public bool IsRemoved()
		{
			return default(bool);
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x2E17040", Offset = "0x2E16040", VA = "0x182E17040")]
		public bool IsTopRemoved()
		{
			return default(bool);
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x0000CE88 File Offset: 0x0000B088
		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x2E16F50", Offset = "0x2E15F50", VA = "0x182E16F50")]
		public bool IsBottomRemoved()
		{
			return default(bool);
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x2E16C80", Offset = "0x2E15C80", VA = "0x182E16C80")]
		public int GetTopId()
		{
			return default(int);
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x2E16C30", Offset = "0x2E15C30", VA = "0x182E16C30")]
		public int GetBottomId()
		{
			return default(int);
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x541260", Offset = "0x540260", VA = "0x180541260")]
		public void SetManager(TreeCutManager manager)
		{
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x2E18070", Offset = "0x2E17070", VA = "0x182E18070")]
		public void SetGameObjectParent(Transform newParent)
		{
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x2E18410", Offset = "0x2E17410", VA = "0x182E18410")]
		public TreeCutCell()
		{
		}

		// Token: 0x04002860 RID: 10336
		[Token(Token = "0x4002860")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _cellGameObject;

		// Token: 0x04002861 RID: 10337
		[Token(Token = "0x4002861")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TreeCutCellRemovedFlags _removedFlags;

		// Token: 0x04002862 RID: 10338
		[Token(Token = "0x4002862")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _id;

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<int> _neighbors;

		// Token: 0x04002864 RID: 10340
		[Token(Token = "0x4002864")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _removed;

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _asleep;

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _outer;

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _layer;

		// Token: 0x04002868 RID: 10344
		[Token(Token = "0x4002868")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _frontId;

		// Token: 0x04002869 RID: 10345
		[Token(Token = "0x4002869")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _backId;

		// Token: 0x0400286A RID: 10346
		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x38")]
		private TreeCutManager _manager;
	}
}
