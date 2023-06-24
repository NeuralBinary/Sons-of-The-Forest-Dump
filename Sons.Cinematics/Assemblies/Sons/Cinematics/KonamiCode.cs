using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Assemblies.Sons.Cinematics
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class KonamiCode : MonoBehaviour
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2D56C90", Offset = "0x2D55290", VA = "0x182D56C90")]
		private static bool Up()
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2D56D90", Offset = "0x2D55390", VA = "0x182D56D90")]
		private static bool Down()
		{
			return default(bool);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2D56E90", Offset = "0x2D55490", VA = "0x182D56E90")]
		private static bool Left()
		{
			return default(bool);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2D56F90", Offset = "0x2D55590", VA = "0x182D56F90")]
		private static bool Right()
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2D57090", Offset = "0x2D55690", VA = "0x182D57090")]
		private static bool A()
		{
			return default(bool);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2D57190", Offset = "0x2D55790", VA = "0x182D57190")]
		private static bool B()
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2D57290", Offset = "0x2D55890", VA = "0x182D57290")]
		private void Update()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2D57330", Offset = "0x2D55930", VA = "0x182D57330")]
		private bool CanCheckNextStep()
		{
			return default(bool);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2D57360", Offset = "0x2D55960", VA = "0x182D57360")]
		private bool CheckNextStep()
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2D573D0", Offset = "0x2D559D0", VA = "0x182D573D0")]
		private void CheckCodeWasCompleted()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2D57410", Offset = "0x2D55A10", VA = "0x182D57410")]
		public KonamiCode()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D57720", Offset = "0x2D55D20", VA = "0x182D57720")]
		[CompilerGenerated]
		internal static bool <CanCheckNextStep>g__AnyKeyOrButtonDown|11_0()
		{
			return default(bool);
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _onCodeCompleted;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		private int _currentStepNum;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x2C")]
		private bool _waitingKeyUp;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x30")]
		private readonly Func<bool>[] _steps;
	}
}
