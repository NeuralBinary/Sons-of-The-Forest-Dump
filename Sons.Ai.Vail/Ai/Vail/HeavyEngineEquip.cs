using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation.Mae;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[AddComponentMenu("Sons/Ai/HeavyEngineEquip")]
	public class HeavyEngineEquip : MonoBehaviour, IActorVariation
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2AF8740", Offset = "0x2AF6D40", VA = "0x182AF8740")]
		private static IEnumerable GetAnimationLayers()
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2AF8790", Offset = "0x2AF6D90", VA = "0x182AF8790")]
		private static IEnumerable GetAnimationVars()
		{
			return null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2AF87E0", Offset = "0x2AF6DE0", VA = "0x182AF87E0")]
		private void Start()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2AF8800", Offset = "0x2AF6E00", VA = "0x182AF8800")]
		private void ToggleEngineEquip()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2AF8820", Offset = "0x2AF6E20", VA = "0x182AF8820")]
		public void SetEngineEquipped(bool active)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2AF89F0", Offset = "0x2AF6FF0", VA = "0x182AF89F0", Slot = "4")]
		public void ApplyVariation(int variationId)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2AF8A00", Offset = "0x2AF7000", VA = "0x182AF8A00")]
		public HeavyEngineEquip()
		{
		}

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _startEquipped;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _engineVariationId;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _showObject;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hideObject;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Delayed]
		protected AnimationParameter _engineLayer;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x70")]
		[Delayed]
		[SerializeField]
		protected AnimationParameter _animVar;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0xA0")]
		private bool _holdingEngine;
	}
}
