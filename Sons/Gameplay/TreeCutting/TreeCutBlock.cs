using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x0200082D RID: 2093
	[Token(Token = "0x200082D")]
	public class TreeCutBlock : MonoBehaviour
	{
		// Token: 0x06003AF2 RID: 15090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x35835A0", Offset = "0x3581BA0", VA = "0x1835835A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF3")]
		[Address(RVA = "0x35838E0", Offset = "0x3581EE0", VA = "0x1835838E0")]
		private void CacheCollider()
		{
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF4")]
		[Address(RVA = "0x3583A10", Offset = "0x3582010", VA = "0x183583A10")]
		private void CacheMeshRenderer()
		{
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x3583B40", Offset = "0x3582140", VA = "0x183583B40")]
		private void CacheMeshFilter()
		{
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetTreeCutManager(TreeCutManager cutManager)
		{
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetCellId(int Id)
		{
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x3583C70", Offset = "0x3582270", VA = "0x183583C70")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x3583C90", Offset = "0x3582290", VA = "0x183583C90")]
		private void FakeOnTriggerEnter()
		{
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x3583CB0", Offset = "0x35822B0", VA = "0x183583CB0")]
		private void OnTriggerEnterInternal(Collider other, bool checkCollider = true, bool checkHitState = true)
		{
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x35841D0", Offset = "0x35827D0", VA = "0x1835841D0")]
		private void HitSignal()
		{
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFC")]
		[Address(RVA = "0x35841E0", Offset = "0x35827E0", VA = "0x1835841E0")]
		private void HitEvent(Collider source)
		{
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFD")]
		[Address(RVA = "0x3584290", Offset = "0x3582890", VA = "0x183584290")]
		public MeshFilter GetMeshFilter()
		{
			return null;
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFE")]
		[Address(RVA = "0x35842B0", Offset = "0x35828B0", VA = "0x1835842B0")]
		public Collider GetCollider()
		{
			return null;
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFF")]
		[Address(RVA = "0x35842D0", Offset = "0x35828D0", VA = "0x1835842D0")]
		public MeshRenderer GetMeshRenderer()
		{
			return null;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B00")]
		[Address(RVA = "0x35842F0", Offset = "0x35828F0", VA = "0x1835842F0")]
		public void SetCachedCollider(SphereCollider sourceCollider, TreeCutBlock sourceBlock)
		{
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x35843C0", Offset = "0x35829C0", VA = "0x1835843C0")]
		public void AddLinkedBlock(TreeCutBlock source)
		{
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B02")]
		[Address(RVA = "0x3584460", Offset = "0x3582A60", VA = "0x183584460")]
		public void SetRemoved(bool value)
		{
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x3584720", Offset = "0x3582D20", VA = "0x183584720")]
		public void ResetColliderRequest()
		{
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x3584730", Offset = "0x3582D30", VA = "0x183584730")]
		private void AddColliderRequest()
		{
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B05")]
		[Address(RVA = "0x3584740", Offset = "0x3582D40", VA = "0x183584740")]
		private void RemoveColliderRequest()
		{
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B06")]
		[Address(RVA = "0x3584750", Offset = "0x3582D50", VA = "0x183584750")]
		private void RefreshColliderState()
		{
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B07")]
		[Address(RVA = "0x35848C0", Offset = "0x3582EC0", VA = "0x1835848C0")]
		public TreeCutBlock()
		{
		}

		// Token: 0x04003233 RID: 12851
		[Token(Token = "0x4003233")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _cellId;

		// Token: 0x04003234 RID: 12852
		[Token(Token = "0x4003234")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TreeCutManager _cutManager;

		// Token: 0x04003235 RID: 12853
		[Token(Token = "0x4003235")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _cachedMeshFilter;

		// Token: 0x04003236 RID: 12854
		[Token(Token = "0x4003236")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshRenderer _cachedMeshRenderer;

		// Token: 0x04003237 RID: 12855
		[Token(Token = "0x4003237")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Collider _cachedCollider;

		// Token: 0x04003238 RID: 12856
		[Token(Token = "0x4003238")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TreeCutBlock _cachedColliderSource;

		// Token: 0x04003239 RID: 12857
		[Token(Token = "0x4003239")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<TreeCutBlock> _linkedBlocks;

		// Token: 0x0400323A RID: 12858
		[Token(Token = "0x400323A")]
		[FieldOffset(Offset = "0x58")]
		private bool _removed;

		// Token: 0x0400323B RID: 12859
		[Token(Token = "0x400323B")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int _colliderRequest;
	}
}
