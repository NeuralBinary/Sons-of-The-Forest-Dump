using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	[AddComponentMenu("Sons/Characters/Simple Animal Stream Zone")]
	public class SimpleAnimalStreamZone : MonoBehaviour
	{
		// Token: 0x06003614 RID: 13844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x6C55A0", Offset = "0x6C45A0", VA = "0x1806C55A0")]
		public void SetAreaPerFish(float value)
		{
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x67DC20", Offset = "0x67CC20", VA = "0x18067DC20")]
		public void SetVerticalOffset(float value)
		{
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x2E98AC0", Offset = "0x2E97AC0", VA = "0x182E98AC0")]
		public void AutoSetup(SimpleAnimal animal, float verticalOffset, float areaPerFish, float minArea, float minDepth, float maxSlopeDegrees, bool createZones)
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x2E98BA0", Offset = "0x2E97BA0", VA = "0x182E98BA0")]
		private void CollectColliderChildren()
		{
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x2E98C10", Offset = "0x2E97C10", VA = "0x182E98C10")]
		public int CreateFishZones(out int totalFishCount)
		{
			return default(int);
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x2E98D00", Offset = "0x2E97D00", VA = "0x182E98D00")]
		public SimpleAnimalStreamZone()
		{
		}

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<BoxCollider> _colliders;

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleAnimal _animalPrefab;

		// Token: 0x04002E61 RID: 11873
		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _verticalOffset;

		// Token: 0x04002E62 RID: 11874
		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _minArea;

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minDepth;

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _maxSlopeDegrees;

		// Token: 0x04002E65 RID: 11877
		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _areaPerFish;
	}
}
