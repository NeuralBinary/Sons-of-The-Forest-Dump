using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000708 RID: 1800
	[Token(Token = "0x2000708")]
	[AddComponentMenu("Sons/Characters/Simple Animal Stream Zone")]
	public class SimpleAnimalStreamZone : MonoBehaviour
	{
		// Token: 0x06002FBB RID: 12219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x781580", Offset = "0x77FB80", VA = "0x180781580")]
		public void SetAreaPerFish(float value)
		{
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
		public void SetVerticalOffset(float value)
		{
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x3466830", Offset = "0x3464E30", VA = "0x183466830")]
		public void AutoSetup(SimpleAnimal animal, float verticalOffset, float areaPerFish, float minArea, float minDepth, float maxSlopeDegrees, bool createZones)
		{
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x3466A20", Offset = "0x3465020", VA = "0x183466A20")]
		private void CollectColliderChildren()
		{
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0000E520 File Offset: 0x0000C720
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x3466B70", Offset = "0x3465170", VA = "0x183466B70")]
		public int CreateFishZones(out int totalFishCount)
		{
			return 0;
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x3466D10", Offset = "0x3465310", VA = "0x183466D10")]
		public SimpleAnimalStreamZone()
		{
		}

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<BoxCollider> _colliders;

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleAnimal _animalPrefab;

		// Token: 0x04002953 RID: 10579
		[Token(Token = "0x4002953")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _verticalOffset;

		// Token: 0x04002954 RID: 10580
		[Token(Token = "0x4002954")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _minArea;

		// Token: 0x04002955 RID: 10581
		[Token(Token = "0x4002955")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minDepth;

		// Token: 0x04002956 RID: 10582
		[Token(Token = "0x4002956")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _maxSlopeDegrees;

		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _areaPerFish;
	}
}
