using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace TheForest.World
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	public class LightFadeIn : MonoBehaviour
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00007680 File Offset: 0x00005880
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000332")]
		public bool ControllingLight
		{
			[Token(Token = "0x60017DB")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017DC")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00007698 File Offset: 0x00005898
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000333")]
		public float IntensityMultiplier
		{
			[Token(Token = "0x60017DD")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60017DE")]
			[Address(RVA = "0x2D63590", Offset = "0x2D61B90", VA = "0x182D63590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x17000334")]
		private float TargetIntensity
		{
			[Token(Token = "0x60017DF")]
			[Address(RVA = "0x3276360", Offset = "0x3274960", VA = "0x183276360")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x3276370", Offset = "0x3274970", VA = "0x183276370")]
		private void Start()
		{
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x3276390", Offset = "0x3274990", VA = "0x183276390")]
		private float CollectIntensity()
		{
			return 0f;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x3276550", Offset = "0x3274B50", VA = "0x183276550")]
		private void OnEnable()
		{
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x3276800", Offset = "0x3274E00", VA = "0x183276800")]
		private void SetIntensity(float targetLightIntensity)
		{
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x32769C0", Offset = "0x3274FC0", VA = "0x1832769C0")]
		private void OnDisable()
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x3276AB0", Offset = "0x32750B0", VA = "0x183276AB0")]
		private IEnumerator FadeInRoutine()
		{
			return null;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x3276B40", Offset = "0x3275140", VA = "0x183276B40")]
		private IEnumerator FadeOutRoutine()
		{
			return null;
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x3276BD0", Offset = "0x32751D0", VA = "0x183276BD0")]
		public LightFadeIn()
		{
		}

		// Token: 0x040016D6 RID: 5846
		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x20")]
		public Light _targetLight;

		// Token: 0x040016D7 RID: 5847
		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0x28")]
		public float _fadeInDuration;

		// Token: 0x040016D8 RID: 5848
		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0x2C")]
		private float _startIntensity;

		// Token: 0x040016D9 RID: 5849
		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0x30")]
		private HDAdditionalLightData _lightData;
	}
}
