using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Lighting
{
	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	public abstract class LightFlickerBase : MonoBehaviour
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0000A6F8 File Offset: 0x000088F8
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D0")]
		public float IntensityMultiplier
		{
			[Token(Token = "0x6002448")]
			[Address(RVA = "0x6C5560", Offset = "0x6C4560", VA = "0x1806C5560")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002449")]
			[Address(RVA = "0x6C55A0", Offset = "0x6C45A0", VA = "0x1806C55A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x170004D1")]
		public float MaxIntensity
		{
			[Token(Token = "0x600244A")]
			[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244B")]
		[Address(RVA = "0x2D83C30", Offset = "0x2D82C30", VA = "0x182D83C30")]
		private void Update()
		{
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x2D83B80", Offset = "0x2D82B80", VA = "0x182D83B80")]
		private void SetFromLinked(float factor)
		{
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x2D83BE0", Offset = "0x2D82BE0", VA = "0x182D83BE0")]
		private void UpdateFromFactor(float factor)
		{
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x2D83B50", Offset = "0x2D82B50", VA = "0x182D83B50")]
		private void OnEnable()
		{
		}

		// Token: 0x0600244F RID: 9295
		[Token(Token = "0x600244F")]
		public abstract void SetLightIntensity(float intensity);

		// Token: 0x06002450 RID: 9296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x2D83DB0", Offset = "0x2D82DB0", VA = "0x182D83DB0")]
		protected LightFlickerBase()
		{
		}

		// Token: 0x040020B0 RID: 8368
		[Token(Token = "0x40020B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("minIntensity")]
		protected float _minIntensity;

		// Token: 0x040020B1 RID: 8369
		[Token(Token = "0x40020B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FormerlySerializedAs("maxIntensity")]
		private float _maxIntensity;

		// Token: 0x040020B2 RID: 8370
		[Token(Token = "0x40020B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("timeMult")]
		private float _flickerSpeed;

		// Token: 0x040020B3 RID: 8371
		[Token(Token = "0x40020B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<LightFlickerBase> _linkedFlickers;

		// Token: 0x040020B4 RID: 8372
		[Token(Token = "0x40020B4")]
		[FieldOffset(Offset = "0x38")]
		private float _random;

		// Token: 0x040020B5 RID: 8373
		[Token(Token = "0x40020B5")]
		[FieldOffset(Offset = "0x3C")]
		private bool _linkedControlled;
	}
}
