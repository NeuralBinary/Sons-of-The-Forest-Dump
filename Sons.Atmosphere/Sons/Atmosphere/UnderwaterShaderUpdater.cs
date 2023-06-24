using System;
using Il2CppDummyDll;
using Sons.Areas;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class UnderwaterShaderUpdater : MonoBehaviour
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2D50BC0", Offset = "0x2D4F1C0", VA = "0x182D50BC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2D50CA0", Offset = "0x2D4F2A0", VA = "0x182D50CA0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2D50D10", Offset = "0x2D4F310", VA = "0x182D50D10")]
		private void OnAreaMaskChanged(AreaMask oldMask, AreaMask areaMask, PlayerType playerType)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2D50DF0", Offset = "0x2D4F3F0", VA = "0x182D50DF0")]
		private void ApplyCaveSettings(bool value)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2D50EB0", Offset = "0x2D4F4B0", VA = "0x182D50EB0")]
		private void Update()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2D51300", Offset = "0x2D4F900", VA = "0x182D51300")]
		private void UpdateShaderGlobals(GameObject lightGameObject, HDAdditionalLightData hdData)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2D519E0", Offset = "0x2D4FFE0", VA = "0x182D519E0")]
		private static void ApplyValues(Vector3 lightDir, Color lightColor, Color skyAmbient)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2D51C10", Offset = "0x2D50210", VA = "0x182D51C10")]
		public UnderwaterShaderUpdater()
		{
		}

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Light _sunLight;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x28")]
		private HDAdditionalLightData _sunLightHdData;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Light _moonLight;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x38")]
		private HDAdditionalLightData _moonLightHdData;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 _caveLightDir;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[ColorUsage(false, true)]
		private Color _caveLightColor;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x5C")]
		[ColorUsage(false, true)]
		[SerializeField]
		private Color _caveLightAmbient;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private bool _testCaveValues;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x70")]
		private Color _lastSampleLightColor;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 _lastSampleLightDir;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x8C")]
		private Color _lastSampleSkyAmbient;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0xA0")]
		private Color[] Ambient;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3[] shDirections;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SonsMainLightDir;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int SonsMainLightColor;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int SonsSkyAmbient;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0xB0")]
		private bool _caveSettingsOn;
	}
}
