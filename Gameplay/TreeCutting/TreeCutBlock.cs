using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	public class TreeCutBlock : MonoBehaviour
	{
		// Token: 0x06002D10 RID: 11536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x2E15F50", Offset = "0x2E14F50", VA = "0x182E15F50")]
		private void OnValidate()
		{
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D11")]
		[Address(RVA = "0x2E15670", Offset = "0x2E14670", VA = "0x182E15670")]
		private void CacheCollider()
		{
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x2E157B0", Offset = "0x2E147B0", VA = "0x182E157B0")]
		private void CacheMeshRenderer()
		{
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x2E15710", Offset = "0x2E14710", VA = "0x182E15710")]
		private void CacheMeshFilter()
		{
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
		public void SetTreeCutManager(TreeCutManager cutManager)
		{
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x576710", Offset = "0x575710", VA = "0x180576710")]
		public void SetCellId(int Id)
		{
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x2E15F30", Offset = "0x2E14F30", VA = "0x182E15F30")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x2E15850", Offset = "0x2E14850", VA = "0x182E15850")]
		private void FakeOnTriggerEnter()
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x2E15A80", Offset = "0x2E14A80", VA = "0x182E15A80")]
		private void OnTriggerEnterInternal(Collider other, bool checkCollider = true, bool checkHitState = true)
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x2E15A70", Offset = "0x2E14A70", VA = "0x182E15A70")]
		private void HitSignal()
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0x2E158D0", Offset = "0x2E148D0", VA = "0x182E158D0")]
		private void HitEvent(Collider source)
		{
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x2E15890", Offset = "0x2E14890", VA = "0x182E15890")]
		public MeshFilter GetMeshFilter()
		{
			return null;
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x2E15870", Offset = "0x2E14870", VA = "0x182E15870")]
		public Collider GetCollider()
		{
			return null;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x2E158B0", Offset = "0x2E148B0", VA = "0x182E158B0")]
		public MeshRenderer GetMeshRenderer()
		{
			return null;
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x2E16160", Offset = "0x2E15160", VA = "0x182E16160")]
		public void SetCachedCollider(SphereCollider sourceCollider, TreeCutBlock sourceBlock)
		{
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0x2E155C0", Offset = "0x2E145C0", VA = "0x182E155C0")]
		public void AddLinkedBlock(TreeCutBlock source)
		{
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D20")]
		[Address(RVA = "0x2E161B0", Offset = "0x2E151B0", VA = "0x182E161B0")]
		public void SetRemoved(bool value)
		{
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x2E16150", Offset = "0x2E15150", VA = "0x182E16150")]
		public void ResetColliderRequest()
		{
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D22")]
		[Address(RVA = "0x2E155B0", Offset = "0x2E145B0", VA = "0x182E155B0")]
		private void AddColliderRequest()
		{
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x2E16140", Offset = "0x2E15140", VA = "0x182E16140")]
		private void RemoveColliderRequest()
		{
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D24")]
		[Address(RVA = "0x2E16090", Offset = "0x2E15090", VA = "0x182E16090")]
		private void RefreshColliderState()
		{
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x2E16300", Offset = "0x2E15300", VA = "0x182E16300")]
		public TreeCutBlock()
		{
		}

		// Token: 0x04002857 RID: 10327
		[Token(Token = "0x4002857")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _cellId;

		// Token: 0x04002858 RID: 10328
		[Token(Token = "0x4002858")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TreeCutManager _cutManager;

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _cachedMeshFilter;

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshRenderer _cachedMeshRenderer;

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Collider _cachedCollider;

		// Token: 0x0400285C RID: 10332
		[Token(Token = "0x400285C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TreeCutBlock _cachedColliderSource;

		// Token: 0x0400285D RID: 10333
		[Token(Token = "0x400285D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<TreeCutBlock> _linkedBlocks;

		// Token: 0x0400285E RID: 10334
		[Token(Token = "0x400285E")]
		[FieldOffset(Offset = "0x58")]
		private bool _removed;

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int _colliderRequest;
	}
}
