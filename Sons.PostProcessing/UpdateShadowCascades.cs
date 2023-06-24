using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.PostProcessing
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class UpdateShadowCascades : MonoBehaviour
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3113D80", Offset = "0x3112380", VA = "0x183113D80")]
		private void OnValidate()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3114040", Offset = "0x3112640", VA = "0x183114040")]
		private void UpdateGlobalShaderVariables(ShadowsAdditionalSettings additionalShadowSettings)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3114120", Offset = "0x3112720", VA = "0x183114120")]
		public void UpdateShadowSettings(ShadowsAdditionalSettings dayAdditionalShadowSettings, ShadowsAdditionalSettings twilightAdditionalShadowSettings, ShadowsAdditionalSettings nightAdditionalShadowSettings, HDShadowSettings daysShadows, HDShadowSettings twilightShadows, HDShadowSettings nightShadows, Volume dayVolume, Volume twilightVolume, Volume nightVolume)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x31143C0", Offset = "0x31129C0", VA = "0x1831143C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3114470", Offset = "0x3112A70", VA = "0x183114470")]
		private void OnDisable()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x31144D0", Offset = "0x3112AD0", VA = "0x1831144D0")]
		private void Update()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3114B50", Offset = "0x3113150", VA = "0x183114B50")]
		public UpdateShadowCascades()
		{
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _controlsSunLight;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<int> _updateRate;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<int> _updateOffset;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x38")]
		private HDAdditionalLightData _hdAdditionalLightData;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x40")]
		private bool _even;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x44")]
		private int _renderedFrame;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x48")]
		private int _currentCascadeCount;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x4C")]
		private bool _controlSubShadowMapRendering;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int VerySmallShadowCasterThresholdPID;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int SmallShadowCasterThresholdPID;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int TerrainShadowCasterThresholdPID;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x50")]
		private HDShadowSettings _dayShadowSettings;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x58")]
		private HDShadowSettings _twilightShadowSettings;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x60")]
		private HDShadowSettings _nightShadowSettings;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x68")]
		private ShadowsAdditionalSettings _dayAdditionalShadowSettings;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x78")]
		private ShadowsAdditionalSettings _twilightAdditionalShadowSettings;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x88")]
		private ShadowsAdditionalSettings _nightAdditionalShadowSettings;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x98")]
		private Volume _dayVolume;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xA0")]
		private Volume _twilightVolume;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xA8")]
		private Volume _nightVolume;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xB0")]
		private bool _refsAssigned;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xB1")]
		private bool _refreshUpdateMode;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xB2")]
		private bool _dayShadowsActive;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xB3")]
		private bool _twilightShadowsActive;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xB4")]
		private bool _nightShadowsActive;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xB5")]
		private bool _wasZeroedDimmer;
	}
}
