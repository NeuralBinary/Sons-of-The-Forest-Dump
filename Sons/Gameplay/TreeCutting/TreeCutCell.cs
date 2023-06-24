using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x0200082E RID: 2094
	[Token(Token = "0x200082E")]
	[Serializable]
	public class TreeCutCell : ISerializationCallbackReceiver
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A7")]
		public GameObject gameObject
		{
			[Token(Token = "0x6003B08")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x00012048 File Offset: 0x00010248
		[Token(Token = "0x6003B09")]
		[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
		public bool GetRemovedState()
		{
			return default(bool);
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x6003B0A")]
		[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
		public int GetFrontCellId()
		{
			return 0;
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
		public int GetBackCellId()
		{
			return 0;
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0C")]
		[Address(RVA = "0x35849B0", Offset = "0x3582FB0", VA = "0x1835849B0")]
		public void InitializeBlock(Material blockMaterial)
		{
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0D")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetCellGameObject(GameObject cellObj)
		{
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0E")]
		[Address(RVA = "0xA7FDD0", Offset = "0xA7E3D0", VA = "0x180A7FDD0")]
		public void SetId(int id)
		{
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x3584E40", Offset = "0x3583440", VA = "0x183584E40")]
		public void UpdateMesh(IEnumerable<TreeCutMesh> cutMeshes)
		{
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B10")]
		[Address(RVA = "0x35851F0", Offset = "0x35837F0", VA = "0x1835851F0")]
		private void RingModulation(int id, int rings, int segments, int layerPointCount, out int ringSegments, out int modulationValue, out int innerId)
		{
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
		private void PassFrontId(int Id)
		{
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x3585430", Offset = "0x3583A30", VA = "0x183585430")]
		private bool IsOuter(int layerPointCount, int segments)
		{
			return default(bool);
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x3585450", Offset = "0x3583A50", VA = "0x183585450")]
		public void WakeOuter()
		{
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x3585460", Offset = "0x3583A60", VA = "0x183585460")]
		public void EvaluateNeighbors(int layers, int rings, int segments, int ccount, int lcount, TreeCutManager manager)
		{
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x3585F10", Offset = "0x3584510", VA = "0x183585F10")]
		public void OnBlockCollisionEvent()
		{
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x35861B0", Offset = "0x35847B0", VA = "0x1835861B0")]
		public void OnBlockRemoved(int Id)
		{
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x3586410", Offset = "0x3584A10", VA = "0x183586410")]
		public void ResetCell()
		{
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B18")]
		[Address(RVA = "0x3586430", Offset = "0x3584A30", VA = "0x183586430")]
		public void OnFrontRemoved(TreeCutManager manager)
		{
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x3586690", Offset = "0x3584C90", VA = "0x183586690")]
		private void Awaken()
		{
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1C")]
		[Address(RVA = "0x35866A0", Offset = "0x3584CA0", VA = "0x1835866A0")]
		public void Remove()
		{
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1D")]
		[Address(RVA = "0x3586E20", Offset = "0x3585420", VA = "0x183586E20")]
		public void RemoveSimple()
		{
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1E")]
		[Address(RVA = "0x3586E70", Offset = "0x3585470", VA = "0x183586E70")]
		public void RemoveDelayed()
		{
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x000120A8 File Offset: 0x000102A8
		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
		public bool IsRemoved()
		{
			return default(bool);
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x6003B20")]
		[Address(RVA = "0x3586F60", Offset = "0x3585560", VA = "0x183586F60")]
		public bool IsTopRemoved()
		{
			return default(bool);
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x6003B21")]
		[Address(RVA = "0x3587030", Offset = "0x3585630", VA = "0x183587030")]
		public bool IsBottomRemoved()
		{
			return default(bool);
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x6003B22")]
		[Address(RVA = "0x3587100", Offset = "0x3585700", VA = "0x183587100")]
		public int GetTopId()
		{
			return 0;
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x00012108 File Offset: 0x00010308
		[Token(Token = "0x6003B23")]
		[Address(RVA = "0x3587160", Offset = "0x3585760", VA = "0x183587160")]
		public int GetBottomId()
		{
			return 0;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B24")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void SetManager(TreeCutManager manager)
		{
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x35871C0", Offset = "0x35857C0", VA = "0x1835871C0")]
		public void SetGameObjectParent(Transform newParent)
		{
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x3587280", Offset = "0x3585880", VA = "0x183587280")]
		public TreeCutCell()
		{
		}

		// Token: 0x0400323C RID: 12860
		[Token(Token = "0x400323C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _cellGameObject;

		// Token: 0x0400323D RID: 12861
		[Token(Token = "0x400323D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TreeCutCellRemovedFlags _removedFlags;

		// Token: 0x0400323E RID: 12862
		[Token(Token = "0x400323E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _id;

		// Token: 0x0400323F RID: 12863
		[Token(Token = "0x400323F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<int> _neighbors;

		// Token: 0x04003240 RID: 12864
		[Token(Token = "0x4003240")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _removed;

		// Token: 0x04003241 RID: 12865
		[Token(Token = "0x4003241")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _asleep;

		// Token: 0x04003242 RID: 12866
		[Token(Token = "0x4003242")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _outer;

		// Token: 0x04003243 RID: 12867
		[Token(Token = "0x4003243")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _layer;

		// Token: 0x04003244 RID: 12868
		[Token(Token = "0x4003244")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _frontId;

		// Token: 0x04003245 RID: 12869
		[Token(Token = "0x4003245")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _backId;

		// Token: 0x04003246 RID: 12870
		[Token(Token = "0x4003246")]
		[FieldOffset(Offset = "0x38")]
		private TreeCutManager _manager;
	}
}
