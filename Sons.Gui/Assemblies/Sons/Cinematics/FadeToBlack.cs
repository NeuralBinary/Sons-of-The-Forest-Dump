using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Assemblies.Sons.Cinematics
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class FadeToBlack : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000001")]
		public float Speed
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2FFF9D0", Offset = "0x2FFDFD0", VA = "0x182FFF9D0")]
		private void Awake()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2FFF9E0", Offset = "0x2FFDFE0", VA = "0x182FFF9E0")]
		public void SetSpeed(float speed)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2FFF9F0", Offset = "0x2FFDFF0", VA = "0x182FFF9F0")]
		public void RevertSpeed()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2FFFA00", Offset = "0x2FFE000", VA = "0x182FFFA00")]
		public void ForceTarget(float target)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2FFFAB0", Offset = "0x2FFE0B0", VA = "0x182FFFAB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2FFFB40", Offset = "0x2FFE140", VA = "0x182FFFB40")]
		private void Update()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2FFFC80", Offset = "0x2FFE280", VA = "0x182FFFC80")]
		private void UpdateVolume(float factor)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2FFFE70", Offset = "0x2FFE470", VA = "0x182FFFE70")]
		private bool CurrentAdjusted()
		{
			return default(bool);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2FFFFC0", Offset = "0x2FFE5C0", VA = "0x182FFFFC0")]
		public void StartFadeToBlack()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2FFFFD0", Offset = "0x2FFE5D0", VA = "0x182FFFFD0")]
		public void StartFadeFromBlack()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2FFFFE0", Offset = "0x2FFE5E0", VA = "0x182FFFFE0")]
		public bool IsAtTarget()
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2FFFFF0", Offset = "0x2FFE5F0", VA = "0x182FFFFF0")]
		public void ForceBlack()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3000000", Offset = "0x2FFE600", VA = "0x183000000")]
		public void ForceClear()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3000010", Offset = "0x2FFE610", VA = "0x183000010")]
		public FadeToBlack()
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _volume;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _speed;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _fadeInCurve;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _fadeOutCurve;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _useVignette;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _target;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _currentLinear;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x4C")]
		private float _currentSampled;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x50")]
		private float _defaultSpeed;
	}
}
