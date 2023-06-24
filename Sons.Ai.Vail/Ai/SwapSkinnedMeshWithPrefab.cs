using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[AddComponentMenu("Sons/Ai/SwapSkinnedMeshWithPrefab")]
	public class SwapSkinnedMeshWithPrefab : MonoBehaviour
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2AF2AE0", Offset = "0x2AF10E0", VA = "0x182AF2AE0")]
		[ContextMenu("Swap Mesh")]
		public void SwapMesh()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2AF2FF0", Offset = "0x2AF15F0", VA = "0x182AF2FF0")]
		public void SwapMeshWithPrefab()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SwapSkinnedMeshWithPrefab()
		{
		}

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _objectToReplace;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _destroyReplacedObject;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _destroyThisComponentAfterSwap;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _meshAsset;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _updateRenderBounds;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _overrideRootBone;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _rootBoneOverride;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _newMeshObject;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<Transform> _hideObjects;
	}
}
