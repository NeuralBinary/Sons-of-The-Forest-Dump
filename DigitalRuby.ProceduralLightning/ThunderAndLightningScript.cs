using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class ThunderAndLightningScript : MonoBehaviour
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA52550", Offset = "0xA50B50", VA = "0x180A52550")]
		private void Start()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA52BD0", Offset = "0xA511D0", VA = "0x180A52BD0")]
		private void Update()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA52D60", Offset = "0xA51360", VA = "0x180A52D60")]
		public void CallNormalLightning()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA52E60", Offset = "0xA51460", VA = "0x180A52E60")]
		public void CallNormalLightning(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA52F60", Offset = "0xA51560", VA = "0x180A52F60")]
		public void CallIntenseLightning()
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA53060", Offset = "0xA51660", VA = "0x180A53060")]
		public void CallIntenseLightning(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x1700003D")]
		public float SkyboxExposureOriginal
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xA53160", Offset = "0xA51760", VA = "0x180A53160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public bool EnableLightning
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xA53170", Offset = "0xA51770", VA = "0x180A53170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xA53180", Offset = "0xA51780", VA = "0x180A53180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA53190", Offset = "0xA51790", VA = "0x180A53190")]
		public ThunderAndLightningScript()
		{
		}

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Lightning bolt script - optional, leave null if you don't want lightning bolts")]
		public LightningBoltPrefabScript LightningBoltScript;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Camera where the lightning should be centered over. Defaults to main camera.")]
		public Camera Camera;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x30")]
		[SingleLine("Random interval between strikes.")]
		public RangeOfFloats LightningIntervalTimeRange;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Probability (0-1) of an intense lightning bolt that hits really close. Intense lightning has increased brightness and louder thunder compared to normal lightning, and the thunder sounds plays a lot sooner.")]
		[Range(0f, 1f)]
		public float LightningIntenseProbability;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Sounds to play for normal thunder. One will be chosen at random for each lightning strike. Depending on intensity, some normal lightning may not play a thunder sound.")]
		public AudioClip[] ThunderSoundsNormal;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Sounds to play for intense thunder. One will be chosen at random for each lightning strike.")]
		public AudioClip[] ThunderSoundsIntense;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Whether lightning strikes should always try to be in the camera view")]
		public bool LightningAlwaysVisible;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		[Tooltip("The chance lightning will simply be in the clouds with no visible bolt")]
		public float CloudLightningChance;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Whether to modify the skybox exposure when lightning is created")]
		public bool ModifySkyboxExposure;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x5C")]
		[Range(1f, 10000f)]
		[Tooltip("Base point light range for lightning bolts. Increases as intensity increases.")]
		public float BaseLightRange;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Starting y value for the lightning strikes")]
		[Range(0f, 100000f)]
		public float LightningYStart;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x64")]
		[Range(0f, 1f)]
		[Tooltip("Volume multiplier")]
		public float VolumeMultiplier;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x68")]
		private float skyboxExposureOriginal;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x6C")]
		private float skyboxExposureStorm;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x70")]
		private float nextLightningTime;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x74")]
		private bool lightningInProgress;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x78")]
		private AudioSource audioSourceThunder;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x80")]
		private ThunderAndLightningScript.LightningBoltHandler lightningBoltHandler;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x88")]
		private Material skyboxMaterial;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x90")]
		private AudioClip lastThunderSound;

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		private class LightningBoltHandler
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060001CC RID: 460 RVA: 0x00002684 File Offset: 0x00000884
			// (set) Token: 0x060001CD RID: 461 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700003F")]
			public float VolumeMultiplier
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060001CE RID: 462 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xA53210", Offset = "0xA51810", VA = "0x180A53210")]
			public LightningBoltHandler(ThunderAndLightningScript script)
			{
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xA53360", Offset = "0xA51960", VA = "0x180A53360")]
			private void UpdateLighting()
			{
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xA534C0", Offset = "0xA51AC0", VA = "0x180A534C0")]
			private void CalculateNextLightningTime()
			{
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xA53640", Offset = "0xA51C40", VA = "0x180A53640")]
			public IEnumerator ProcessLightning(Vector3? _start, Vector3? _end, bool intense, bool visible)
			{
				return null;
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xA53720", Offset = "0xA51D20", VA = "0x180A53720")]
			private void Strike(Vector3? _start, Vector3? _end, bool intense, float intensity, Camera camera, Camera visibleInCamera)
			{
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xA54720", Offset = "0xA52D20", VA = "0x180A54720")]
			private void CheckForLightning()
			{
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xA53360", Offset = "0xA51960", VA = "0x180A53360")]
			public void Update()
			{
			}

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			[FieldOffset(Offset = "0x18")]
			private ThunderAndLightningScript script;

			// Token: 0x04000235 RID: 565
			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x20")]
			private readonly System.Random random;
		}
	}
}
