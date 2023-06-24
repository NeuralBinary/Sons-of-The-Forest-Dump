using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	public class InWorldAutoStorage : MonoBehaviour
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x33D8130", Offset = "0x33D6730", VA = "0x1833D8130")]
		private void Start()
		{
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x33D81E0", Offset = "0x33D67E0", VA = "0x1833D81E0")]
		private void OnTriggerEnter(Collider sourceCollider)
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x33D86C0", Offset = "0x33D6CC0", VA = "0x1833D86C0")]
		private IEnumerator TweenInPosition(Transform fromTr, GameObject layoutGo)
		{
			return null;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x33D8820", Offset = "0x33D6E20", VA = "0x1833D8820")]
		private void CleanUpOrInitialize(GameObject layoutGo)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x33D8CE0", Offset = "0x33D72E0", VA = "0x1833D8CE0")]
		private static void SetActiveColliders(GameObject layoutGo, bool value, ref InWorldLayoutItem worldLayoutItem)
		{
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x33D8ED0", Offset = "0x33D74D0", VA = "0x1833D8ED0")]
		private void RevertPositionAndRotation(GameObject layoutGo)
		{
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283C")]
		[Address(RVA = "0x33D9000", Offset = "0x33D7600", VA = "0x1833D9000")]
		private static void UpdateWorldTransform(Transform parent, Vector3 localPos, Quaternion localRot, out Vector3 layoutFinalPos, out Quaternion layoutFinalRot)
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283D")]
		[Address(RVA = "0x33D9280", Offset = "0x33D7880", VA = "0x1833D9280")]
		public InWorldAutoStorage()
		{
		}

		// Token: 0x04002453 RID: 9299
		[Token(Token = "0x4002453")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InWorldLayoutItemGroup _storage;

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lerpDuration;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Coroutine> _existingCoroutines;

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<GameObject, InWorldAutoStorage.PositionAndRotation> _baseTransforms;

		// Token: 0x0200060E RID: 1550
		[Token(Token = "0x200060E")]
		public class PositionAndRotation
		{
			// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283E")]
			[Address(RVA = "0x28DA560", Offset = "0x28D8B60", VA = "0x1828DA560")]
			public PositionAndRotation(Vector3 localPosition, Quaternion localRotation)
			{
			}

			// Token: 0x04002457 RID: 9303
			[Token(Token = "0x4002457")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 Position;

			// Token: 0x04002458 RID: 9304
			[Token(Token = "0x4002458")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion Rotation;
		}
	}
}
