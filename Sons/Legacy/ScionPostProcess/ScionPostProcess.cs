using System;
using Il2CppDummyDll;
using Sons.Legacy.ScionPostProcess.Scripts;
using Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes;
using Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	[AddComponentMenu("Image Effects/Scion Post Process")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ScionPostProcess : MonoBehaviour
	{
		// Token: 0x06002554 RID: 9556 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
		private bool ShowGrain()
		{
			return default(bool);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
		private bool ShowVignette()
		{
			return default(bool);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x9EA6A0", Offset = "0x9E8CA0", VA = "0x1809EA6A0")]
		private bool ShowChromaticAberration()
		{
			return default(bool);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
		private bool ShowTonemapping()
		{
			return default(bool);
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
		private bool ShowBloom()
		{
			return default(bool);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x339B830", Offset = "0x3399E30", VA = "0x18339B830")]
		private bool ShowLensDirt()
		{
			return default(bool);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x339B840", Offset = "0x3399E40", VA = "0x18339B840")]
		private bool ShowLensDirtSettings()
		{
			return default(bool);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
		private bool ShowCameraMode()
		{
			return default(bool);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x339B920", Offset = "0x3399F20", VA = "0x18339B920")]
		private bool ShowExposureComp()
		{
			return default(bool);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x339B930", Offset = "0x3399F30", VA = "0x18339B930")]
		private bool ShowExposureAdaption()
		{
			return default(bool);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x339B950", Offset = "0x3399F50", VA = "0x18339B950")]
		private bool ShowDownsampleBloomExposure()
		{
			return default(bool);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x600255F")]
		[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
		private bool ShowFocalLength()
		{
			return default(bool);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6002560")]
		[Address(RVA = "0x339B970", Offset = "0x3399F70", VA = "0x18339B970")]
		private bool ShowFNumber()
		{
			return default(bool);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6002561")]
		[Address(RVA = "0x339B9A0", Offset = "0x3399FA0", VA = "0x18339B9A0")]
		private bool ShowISO()
		{
			return default(bool);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x339B9A0", Offset = "0x3399FA0", VA = "0x18339B9A0")]
		private bool ShowShutterSpeed()
		{
			return default(bool);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
		private bool ShowDepthOfField()
		{
			return default(bool);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x339B9B0", Offset = "0x3399FB0", VA = "0x18339B9B0")]
		private bool ShowPointAverage()
		{
			return default(bool);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private bool ShowFocalDistance()
		{
			return default(bool);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private bool ShowFocalRange()
		{
			return default(bool);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x339B9D0", Offset = "0x3399FD0", VA = "0x18339B9D0")]
		private bool ShowCCTex1()
		{
			return default(bool);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private bool ShowCCTex2()
		{
			return default(bool);
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0000AFE0 File Offset: 0x000091E0
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E6")]
		public CameraMode cameraMode
		{
			[Token(Token = "0x6002569")]
			[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0")]
			get
			{
				return CameraMode.Off;
			}
			[Token(Token = "0x600256A")]
			[Address(RVA = "0x339B9E0", Offset = "0x3399FE0", VA = "0x18339B9E0")]
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0000AFF8 File Offset: 0x000091F8
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E7")]
		public bool tonemapping
		{
			[Token(Token = "0x600256B")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600256C")]
			[Address(RVA = "0x339BA20", Offset = "0x339A020", VA = "0x18339BA20")]
			set
			{
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0000B010 File Offset: 0x00009210
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E8")]
		public bool bloom
		{
			[Token(Token = "0x600256D")]
			[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600256E")]
			[Address(RVA = "0x339BA50", Offset = "0x339A050", VA = "0x18339BA50")]
			set
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0000B028 File Offset: 0x00009228
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E9")]
		public bool lensDirt
		{
			[Token(Token = "0x600256F")]
			[Address(RVA = "0x2A88E50", Offset = "0x2A87450", VA = "0x182A88E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002570")]
			[Address(RVA = "0x339BA80", Offset = "0x339A080", VA = "0x18339BA80")]
			set
			{
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EA")]
		public Texture2D lensDirtTexture
		{
			[Token(Token = "0x6002571")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002572")]
			[Address(RVA = "0x339BAB0", Offset = "0x339A0B0", VA = "0x18339BAB0")]
			set
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x0000B040 File Offset: 0x00009240
		// (set) Token: 0x06002574 RID: 9588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EB")]
		public bool depthOfField
		{
			[Token(Token = "0x6002573")]
			[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002574")]
			[Address(RVA = "0x339BB90", Offset = "0x339A190", VA = "0x18339BB90")]
			set
			{
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x0000B058 File Offset: 0x00009258
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EC")]
		public float bloomIntensity
		{
			[Token(Token = "0x6002575")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002576")]
			[Address(RVA = "0x339BBC0", Offset = "0x339A1C0", VA = "0x18339BBC0")]
			set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x0000B070 File Offset: 0x00009270
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004ED")]
		public float bloomBrightness
		{
			[Token(Token = "0x6002577")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002578")]
			[Address(RVA = "0x339BBF0", Offset = "0x339A1F0", VA = "0x18339BBF0")]
			set
			{
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x0000B088 File Offset: 0x00009288
		// (set) Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EE")]
		public int bloomDownsamples
		{
			[Token(Token = "0x6002579")]
			[Address(RVA = "0xA2FB30", Offset = "0xA2E130", VA = "0x180A2FB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600257A")]
			[Address(RVA = "0x339BC20", Offset = "0x339A220", VA = "0x18339BC20")]
			set
			{
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x0000B0A0 File Offset: 0x000092A0
		// (set) Token: 0x0600257C RID: 9596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EF")]
		public float lensDirtIntensity
		{
			[Token(Token = "0x600257B")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600257C")]
			[Address(RVA = "0x339BCC0", Offset = "0x339A2C0", VA = "0x18339BCC0")]
			set
			{
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x0000B0B8 File Offset: 0x000092B8
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F0")]
		public float lensDirtBrightness
		{
			[Token(Token = "0x600257D")]
			[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600257E")]
			[Address(RVA = "0x339BCF0", Offset = "0x339A2F0", VA = "0x18339BCF0")]
			set
			{
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x0000B0D0 File Offset: 0x000092D0
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F1")]
		public DepthFocusMode depthFocusMode
		{
			[Token(Token = "0x600257F")]
			[Address(RVA = "0xAFF380", Offset = "0xAFD980", VA = "0x180AFF380")]
			get
			{
				return (DepthFocusMode)0;
			}
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x339BD20", Offset = "0x339A320", VA = "0x18339BD20")]
			set
			{
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x0000B0E8 File Offset: 0x000092E8
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F2")]
		public float maxCoCRadius
		{
			[Token(Token = "0x6002581")]
			[Address(RVA = "0x2739890", Offset = "0x2737E90", VA = "0x182739890")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002582")]
			[Address(RVA = "0x339BD50", Offset = "0x339A350", VA = "0x18339BD50")]
			set
			{
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x0000B100 File Offset: 0x00009300
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F3")]
		public DepthOfFieldQuality depthOfFieldQuality
		{
			[Token(Token = "0x6002583")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			get
			{
				return DepthOfFieldQuality.Normal;
			}
			[Token(Token = "0x6002584")]
			[Address(RVA = "0x339BD80", Offset = "0x339A380", VA = "0x18339BD80")]
			set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x0000B118 File Offset: 0x00009318
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F4")]
		public Vector2 pointAveragePosition
		{
			[Token(Token = "0x6002585")]
			[Address(RVA = "0x339BE00", Offset = "0x339A400", VA = "0x18339BE00")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002586")]
			[Address(RVA = "0x339BE20", Offset = "0x339A420", VA = "0x18339BE20")]
			set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x0000B130 File Offset: 0x00009330
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F5")]
		public float pointAverageRange
		{
			[Token(Token = "0x6002587")]
			[Address(RVA = "0x2739970", Offset = "0x2737F70", VA = "0x182739970")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002588")]
			[Address(RVA = "0x339BE50", Offset = "0x339A450", VA = "0x18339BE50")]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x0000B148 File Offset: 0x00009348
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F6")]
		public bool visualizePointFocus
		{
			[Token(Token = "0x6002589")]
			[Address(RVA = "0x2A27570", Offset = "0x2A25B70", VA = "0x182A27570")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600258A")]
			[Address(RVA = "0x339BE80", Offset = "0x339A480", VA = "0x18339BE80")]
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x0000B160 File Offset: 0x00009360
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F7")]
		public float depthAdaptionSpeed
		{
			[Token(Token = "0x600258B")]
			[Address(RVA = "0x27399D0", Offset = "0x2737FD0", VA = "0x1827399D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600258C")]
			[Address(RVA = "0x339BEB0", Offset = "0x339A4B0", VA = "0x18339BEB0")]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x0000B178 File Offset: 0x00009378
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F8")]
		public float focalDistance
		{
			[Token(Token = "0x600258D")]
			[Address(RVA = "0x2805EE0", Offset = "0x28044E0", VA = "0x182805EE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600258E")]
			[Address(RVA = "0x339BEE0", Offset = "0x339A4E0", VA = "0x18339BEE0")]
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x0000B190 File Offset: 0x00009390
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F9")]
		public float focalRange
		{
			[Token(Token = "0x600258F")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002590")]
			[Address(RVA = "0x339BF10", Offset = "0x339A510", VA = "0x18339BF10")]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x0000B1A8 File Offset: 0x000093A8
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FA")]
		public ColorGradingMode colorGradingMode
		{
			[Token(Token = "0x6002591")]
			[Address(RVA = "0xAFF480", Offset = "0xAFDA80", VA = "0x180AFF480")]
			get
			{
				return ColorGradingMode.Off;
			}
			[Token(Token = "0x6002592")]
			[Address(RVA = "0x339BF40", Offset = "0x339A540", VA = "0x18339BF40")]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FB")]
		public Texture2D colorGradingTex1
		{
			[Token(Token = "0x6002593")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002594")]
			[Address(RVA = "0x339C040", Offset = "0x339A640", VA = "0x18339C040")]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FC")]
		public Texture2D colorGradingTex2
		{
			[Token(Token = "0x6002595")]
			[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002596")]
			[Address(RVA = "0x339C200", Offset = "0x339A800", VA = "0x18339C200")]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x0000B1C0 File Offset: 0x000093C0
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FD")]
		public float colorGradingBlendFactor
		{
			[Token(Token = "0x6002597")]
			[Address(RVA = "0x1342C10", Offset = "0x1341210", VA = "0x181342C10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002598")]
			[Address(RVA = "0x339C2E0", Offset = "0x339A8E0", VA = "0x18339C2E0")]
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x0000B1D8 File Offset: 0x000093D8
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FE")]
		public ColorGradingCompatibility colorGradingCompatibility
		{
			[Token(Token = "0x6002599")]
			[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0")]
			get
			{
				return (ColorGradingCompatibility)0;
			}
			[Token(Token = "0x600259A")]
			[Address(RVA = "0x339C310", Offset = "0x339A910", VA = "0x18339C310")]
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x0000B1F0 File Offset: 0x000093F0
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FF")]
		public bool userControlledFocalLength
		{
			[Token(Token = "0x600259B")]
			[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600259C")]
			[Address(RVA = "0x7282F0", Offset = "0x7268F0", VA = "0x1807282F0")]
			set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x0000B208 File Offset: 0x00009408
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000500")]
		public float focalLength
		{
			[Token(Token = "0x600259D")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600259E")]
			[Address(RVA = "0x339C340", Offset = "0x339A940", VA = "0x18339C340")]
			set
			{
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x0000B220 File Offset: 0x00009420
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000501")]
		public float fNumber
		{
			[Token(Token = "0x600259F")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025A0")]
			[Address(RVA = "0x339C370", Offset = "0x339A970", VA = "0x18339C370")]
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x0000B238 File Offset: 0x00009438
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000502")]
		public float ISO
		{
			[Token(Token = "0x60025A1")]
			[Address(RVA = "0x179D730", Offset = "0x179BD30", VA = "0x18179D730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025A2")]
			[Address(RVA = "0x339C3A0", Offset = "0x339A9A0", VA = "0x18339C3A0")]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x0000B250 File Offset: 0x00009450
		// (set) Token: 0x060025A4 RID: 9636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000503")]
		public float shutterSpeed
		{
			[Token(Token = "0x60025A3")]
			[Address(RVA = "0x7282C0", Offset = "0x7268C0", VA = "0x1807282C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025A4")]
			[Address(RVA = "0x339C3D0", Offset = "0x339A9D0", VA = "0x18339C3D0")]
			set
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x0000B268 File Offset: 0x00009468
		// (set) Token: 0x060025A6 RID: 9638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000504")]
		public float adaptionSpeed
		{
			[Token(Token = "0x60025A5")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025A6")]
			[Address(RVA = "0x339C400", Offset = "0x339AA00", VA = "0x18339C400")]
			set
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x0000B280 File Offset: 0x00009480
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000505")]
		public Vector2 minMaxExposure
		{
			[Token(Token = "0x60025A7")]
			[Address(RVA = "0x12433A0", Offset = "0x12419A0", VA = "0x1812433A0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60025A8")]
			[Address(RVA = "0x339C430", Offset = "0x339AA30", VA = "0x18339C430")]
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x0000B298 File Offset: 0x00009498
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000506")]
		public float exposureCompensation
		{
			[Token(Token = "0x60025A9")]
			[Address(RVA = "0x728320", Offset = "0x726920", VA = "0x180728320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025AA")]
			[Address(RVA = "0x339C460", Offset = "0x339AA60", VA = "0x18339C460")]
			set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x0000B2B0 File Offset: 0x000094B0
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000507")]
		public bool grain
		{
			[Token(Token = "0x60025AB")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025AC")]
			[Address(RVA = "0x339C490", Offset = "0x339AA90", VA = "0x18339C490")]
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x0000B2C8 File Offset: 0x000094C8
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000508")]
		public float grainIntensity
		{
			[Token(Token = "0x60025AD")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025AE")]
			[Address(RVA = "0x339C4D0", Offset = "0x339AAD0", VA = "0x18339C4D0")]
			set
			{
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x0000B2E0 File Offset: 0x000094E0
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000509")]
		public bool vignette
		{
			[Token(Token = "0x60025AF")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0x339C510", Offset = "0x339AB10", VA = "0x18339C510")]
			set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0000B2F8 File Offset: 0x000094F8
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050A")]
		public float vignetteIntensity
		{
			[Token(Token = "0x60025B1")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025B2")]
			[Address(RVA = "0x339C550", Offset = "0x339AB50", VA = "0x18339C550")]
			set
			{
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x0000B310 File Offset: 0x00009510
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050B")]
		public float vignetteScale
		{
			[Token(Token = "0x60025B3")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025B4")]
			[Address(RVA = "0x339C590", Offset = "0x339AB90", VA = "0x18339C590")]
			set
			{
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0000B328 File Offset: 0x00009528
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050C")]
		public Color vignetteColor
		{
			[Token(Token = "0x60025B5")]
			[Address(RVA = "0x339C5C0", Offset = "0x339ABC0", VA = "0x18339C5C0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60025B6")]
			[Address(RVA = "0x339C5D0", Offset = "0x339ABD0", VA = "0x18339C5D0")]
			set
			{
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x0000B340 File Offset: 0x00009540
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050D")]
		public bool chromaticAberration
		{
			[Token(Token = "0x60025B7")]
			[Address(RVA = "0x9EA6A0", Offset = "0x9E8CA0", VA = "0x1809EA6A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025B8")]
			[Address(RVA = "0x339C600", Offset = "0x339AC00", VA = "0x18339C600")]
			set
			{
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0000B358 File Offset: 0x00009558
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050E")]
		public float chromaticAberrationDistortion
		{
			[Token(Token = "0x60025B9")]
			[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025BA")]
			[Address(RVA = "0x339C630", Offset = "0x339AC30", VA = "0x18339C630")]
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0000B370 File Offset: 0x00009570
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050F")]
		public float chromaticAberrationIntensity
		{
			[Token(Token = "0x60025BB")]
			[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025BC")]
			[Address(RVA = "0x339C660", Offset = "0x339AC60", VA = "0x18339C660")]
			set
			{
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x0000B388 File Offset: 0x00009588
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000510")]
		public TonemappingMode tonemappingMode
		{
			[Token(Token = "0x60025BD")]
			[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0")]
			get
			{
				return (TonemappingMode)0;
			}
			[Token(Token = "0x60025BE")]
			[Address(RVA = "0x7C3300", Offset = "0x7C1900", VA = "0x1807C3300")]
			set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x0000B3A0 File Offset: 0x000095A0
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000511")]
		public float whitePoint
		{
			[Token(Token = "0x60025BF")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025C0")]
			[Address(RVA = "0x339C690", Offset = "0x339AC90", VA = "0x18339C690")]
			set
			{
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x339C6C0", Offset = "0x339ACC0", VA = "0x18339C6C0")]
		private void OnEnable()
		{
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C2")]
		[Address(RVA = "0x339D060", Offset = "0x339B660", VA = "0x18339D060")]
		private void OnDisable()
		{
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x339D1A0", Offset = "0x339B7A0", VA = "0x18339D1A0")]
		private void OnPreRender()
		{
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ProcessColorGradingTexture1()
		{
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ProcessColorGradingTexture2()
		{
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x339D250", Offset = "0x339B850", VA = "0x18339D250")]
		private bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x339D620", Offset = "0x339BC20", VA = "0x18339D620")]
		private void SetupPostProcessParameters(PostProcessParameters postProcessParams, RenderTexture source)
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x339DCD0", Offset = "0x339C2D0", VA = "0x18339DCD0")]
		private void SetGlobalParameters(PostProcessParameters postProcessParams)
		{
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x339DED0", Offset = "0x339C4D0", VA = "0x18339DED0")]
		private void SetShaderKeyWords(PostProcessParameters postProcessParams)
		{
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x339E050", Offset = "0x339C650", VA = "0x18339E050")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x339E340", Offset = "0x339C940", VA = "0x18339E340")]
		private void PerformPostProcessing(RenderTexture source, RenderTexture dest, PostProcessParameters postProcessParams)
		{
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x339EBE0", Offset = "0x339D1E0", VA = "0x18339EBE0")]
		public ScionPostProcess()
		{
		}

		// Token: 0x0400218F RID: 8591
		[Token(Token = "0x400218F")]
		[FieldOffset(Offset = "0x20")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Grain")]
		[Toggle("Active", useProperty = "grain", tooltip = "Determines if grain is used")]
		public bool m_grain;

		// Token: 0x04002190 RID: 8592
		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0x24")]
		[Slider("Intensity", useProperty = "grainIntensity", visibleCheck = "ShowGrain", minValue = 0f, maxValue = 1f, tooltip = "How strong the grain effect is")]
		public float m_grainIntensity;

		// Token: 0x04002191 RID: 8593
		[Token(Token = "0x4002191")]
		[FieldOffset(Offset = "0x28")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Vignette")]
		[Toggle("Active", useProperty = "vignette", tooltip = "Determines if vignette is used")]
		public bool m_vignette;

		// Token: 0x04002192 RID: 8594
		[Token(Token = "0x4002192")]
		[FieldOffset(Offset = "0x2C")]
		[Slider("Intensity", useProperty = "vignetteIntensity", visibleCheck = "ShowVignette", minValue = 0f, maxValue = 1f, tooltip = "How strong the vignette effect is")]
		public float m_vignetteIntensity;

		// Token: 0x04002193 RID: 8595
		[Token(Token = "0x4002193")]
		[FieldOffset(Offset = "0x30")]
		[Slider("Scale", useProperty = "vignetteScale", visibleCheck = "ShowVignette", minValue = 0f, maxValue = 1f, tooltip = "How much of the screen is affected")]
		public float m_vignetteScale;

		// Token: 0x04002194 RID: 8596
		[Token(Token = "0x4002194")]
		[FieldOffset(Offset = "0x34")]
		[Field("Color", useProperty = "vignetteColor", visibleCheck = "ShowVignette", tooltip = "What color the vignette effect has")]
		public Color m_vignetteColor;

		// Token: 0x04002195 RID: 8597
		[Token(Token = "0x4002195")]
		[FieldOffset(Offset = "0x44")]
		[Toggle("Active", useProperty = "chromaticAberration", tooltip = "Determines if chromatic aberration is used")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Chromatic Aberration")]
		public bool m_chromaticAberration;

		// Token: 0x04002196 RID: 8598
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x48")]
		[Slider("Distortion Scale", useProperty = "chromaticAberrationDistortion", visibleCheck = "ShowChromaticAberration", minValue = 0f, maxValue = 1f, tooltip = "How much of the screen is affected")]
		public float m_chromaticAberrationDistortion;

		// Token: 0x04002197 RID: 8599
		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x4C")]
		[Slider("Intensity", useProperty = "chromaticAberrationIntensity", visibleCheck = "ShowChromaticAberration", minValue = -30f, maxValue = 30f, tooltip = "How strong the distortion effect is")]
		public float m_chromaticAberrationIntensity;

		// Token: 0x04002198 RID: 8600
		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x50")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Tonemapping")]
		[Toggle("Active", useProperty = "tonemapping", tooltip = "Determines if tonemapping is used")]
		public bool m_tonemapping;

		// Token: 0x04002199 RID: 8601
		[Token(Token = "0x4002199")]
		[FieldOffset(Offset = "0x54")]
		[Field("Mode", useProperty = "tonemappingMode", visibleCheck = "ShowTonemapping", tooltip = "What type of tonemapping algorithm is used")]
		public TonemappingMode m_tonemappingMode;

		// Token: 0x0400219A RID: 8602
		[Token(Token = "0x400219A")]
		[FieldOffset(Offset = "0x58")]
		[Slider("White Point", useProperty = "whitePoint", visibleCheck = "ShowTonemapping", minValue = 0.5f, maxValue = 20f, tooltip = "At what intensity pixels will become white")]
		public float m_whitePoint;

		// Token: 0x0400219B RID: 8603
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x5C")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Bloom")]
		[Toggle("Active", useProperty = "bloom", tooltip = "Determines if bloom is used")]
		public bool m_bloom;

		// Token: 0x0400219C RID: 8604
		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x60")]
		[Slider("Intensity", useProperty = "bloomIntensity", visibleCheck = "ShowBloom", minValue = 0f, maxValue = 1f, tooltip = "How strong the bloom effect is")]
		public float m_bloomIntensity;

		// Token: 0x0400219D RID: 8605
		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x64")]
		[Slider("Brightness", useProperty = "bloomBrightness", visibleCheck = "ShowBloom", minValue = 0.5f, maxValue = 2f, tooltip = "How bright the bloom effect is")]
		public float m_bloomBrightness;

		// Token: 0x0400219E RID: 8606
		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x68")]
		[Slider("Downsamples", useProperty = "bloomDownsamples", visibleCheck = "ShowBloom", minValue = 2f, maxValue = 9f, tooltip = "Number of downsamples")]
		public int m_bloomDownsamples;

		// Token: 0x0400219F RID: 8607
		[Token(Token = "0x400219F")]
		[FieldOffset(Offset = "0x6C")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Lens Dirt", visibleCheck = "ShowBloom")]
		[Toggle("Active", useProperty = "lensDirt", visibleCheck = "ShowBloom", tooltip = "Determines if lens dirt is used")]
		public bool m_lensDirt;

		// Token: 0x040021A0 RID: 8608
		[Token(Token = "0x40021A0")]
		[FieldOffset(Offset = "0x70")]
		[Field("Dirt Texture", useProperty = "lensDirtTexture", visibleCheck = "ShowLensDirt", tooltip = "What type of tonemapping algorithm is used")]
		public Texture2D m_lensDirtTexture;

		// Token: 0x040021A1 RID: 8609
		[Token(Token = "0x40021A1")]
		[FieldOffset(Offset = "0x78")]
		[Slider("Intensity", useProperty = "lensDirtIntensity", visibleCheck = "ShowLensDirtSettings", minValue = 0f, maxValue = 1f, tooltip = "How strong the lens dirt effect is")]
		public float m_lensDirtIntensity;

		// Token: 0x040021A2 RID: 8610
		[Token(Token = "0x40021A2")]
		[FieldOffset(Offset = "0x7C")]
		[Slider("Brightness", useProperty = "lensDirtBrightness", visibleCheck = "ShowLensDirtSettings", minValue = 0.5f, maxValue = 2f, tooltip = "How bright the lens dirt effect is")]
		public float m_lensDirtBrightness;

		// Token: 0x040021A3 RID: 8611
		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x80")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Camera Mode")]
		[Field("Camera Mode", useProperty = "cameraMode", visibleCheck = "ShowCameraMode", tooltip = "What camera mode is used")]
		public CameraMode m_cameraMode;

		// Token: 0x040021A4 RID: 8612
		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x84")]
		[Slider("F Number", useProperty = "fNumber", visibleCheck = "ShowFNumber", minValue = 1f, maxValue = 22f, tooltip = "The F number of the camera")]
		public float m_fNumber;

		// Token: 0x040021A5 RID: 8613
		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x88")]
		[Slider("ISO", useProperty = "ISO", visibleCheck = "ShowISO", minValue = 100f, maxValue = 6400f, tooltip = "The ISO setting of the camera")]
		public float m_ISO;

		// Token: 0x040021A6 RID: 8614
		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x8C")]
		[Slider("Shutter Speed", useProperty = "shutterSpeed", visibleCheck = "ShowShutterSpeed", minValue = 0.00025f, maxValue = 0.033333335f, tooltip = "The shutted speed of the camera")]
		public float m_shutterSpeed;

		// Token: 0x040021A7 RID: 8615
		[Token(Token = "0x40021A7")]
		[FieldOffset(Offset = "0x90")]
		[Toggle("Custom Focal Length", useProperty = "userControlledFocalLength", tooltip = "If false the focal length will instead be derived from the camera's field of view")]
		public bool m_userControlledFocalLength;

		// Token: 0x040021A8 RID: 8616
		[Token(Token = "0x40021A8")]
		[FieldOffset(Offset = "0x94")]
		[Slider("Focal Length", useProperty = "focalLength", visibleCheck = "ShowFocalLength", minValue = 10f, maxValue = 250f, tooltip = "The focal length of the camera in millimeters")]
		public float m_focalLength;

		// Token: 0x040021A9 RID: 8617
		[Token(Token = "0x40021A9")]
		[FieldOffset(Offset = "0x98")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Exposure Settings")]
		[Slider("Exposure Compensation", useProperty = "exposureCompensation", visibleCheck = "ShowExposureComp", minValue = -8f, maxValue = 8f, tooltip = "Allows you to manually compensate towards the desired exposure")]
		public float m_exposureCompensation;

		// Token: 0x040021AA RID: 8618
		[Token(Token = "0x40021AA")]
		[FieldOffset(Offset = "0x9C")]
		[MinMaxSlider("Min Max Exposure", -8f, 24f, useProperty = "minMaxExposure")]
		public Vector2 m_minMaxExposure;

		// Token: 0x040021AB RID: 8619
		[Token(Token = "0x40021AB")]
		[FieldOffset(Offset = "0xA4")]
		[Slider("Adaption Speed", useProperty = "adaptionSpeed", visibleCheck = "ShowExposureAdaption", minValue = 0.1f, maxValue = 8f, tooltip = "How fast the exposure is allowed to change")]
		public float m_adaptionSpeed;

		// Token: 0x040021AC RID: 8620
		[Token(Token = "0x40021AC")]
		[FieldOffset(Offset = "0xA8")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Depth of Field")]
		[Toggle("Active", useProperty = "depthOfField", tooltip = "Determines if depth of field is used")]
		public bool m_depthOfField;

		// Token: 0x040021AD RID: 8621
		[Token(Token = "0x40021AD")]
		[FieldOffset(Offset = "0xAC")]
		[Slider("Max Radius", useProperty = "maxCoCRadius", visibleCheck = "ShowDepthOfField", minValue = 10f, maxValue = 20f, tooltip = "The maximum radius the blur can be. Lower values might have less artifacts")]
		public float m_maxCoCRadius;

		// Token: 0x040021AE RID: 8622
		[Token(Token = "0x40021AE")]
		[FieldOffset(Offset = "0xB0")]
		[Field("Quality Level", useProperty = "depthOfFieldQuality", visibleCheck = "ShowDepthOfField", tooltip = "Dictates how many samples the algorithm does")]
		public DepthOfFieldQuality m_depthOfFieldQuality;

		// Token: 0x040021AF RID: 8623
		[Token(Token = "0x40021AF")]
		[FieldOffset(Offset = "0xB4")]
		[Field("Depth Focus Mode", useProperty = "depthFocusMode", visibleCheck = "ShowDepthOfField", tooltip = "How the depth focus point is chosen")]
		public DepthFocusMode m_depthFocusMode;

		// Token: 0x040021B0 RID: 8624
		[Token(Token = "0x40021B0")]
		[FieldOffset(Offset = "0xB8")]
		[Field("Point Center", useProperty = "pointAveragePosition", visibleCheck = "ShowPointAverage", tooltip = "Where the center of focus is on the screen. [0,0] is the bottom left corner and [1,1] is the top right")]
		public Vector2 m_pointAveragePosition;

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0xC0")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Space(0, 1)]
		[Slider("Point Range", useProperty = "pointAverageRange", visibleCheck = "ShowPointAverage", minValue = 0.01f, maxValue = 1f, tooltip = "How far the point average calculation reaches")]
		public float m_pointAverageRange;

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0xC4")]
		[Toggle("Visualize", useProperty = "visualizePointFocus", visibleCheck = "ShowPointAverage", tooltip = "Show the area of influence on the main screen for visualizaiton")]
		public bool m_visualizePointFocus;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0xC8")]
		[Slider("Adaption Speed", useProperty = "depthAdaptionSpeed", visibleCheck = "ShowPointAverage", minValue = 1f, maxValue = 30f, tooltip = "Dictates how fast the focal distance changes")]
		public float m_depthAdaptionSpeed;

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0xCC")]
		[Field("Focal Distance", useProperty = "focalDistance", visibleCheck = "ShowFocalDistance", tooltip = "The focal distance in meters")]
		public float m_focalDistance;

		// Token: 0x040021B5 RID: 8629
		[Token(Token = "0x40021B5")]
		[FieldOffset(Offset = "0xD0")]
		[Slider("Depth Range", useProperty = "focalRange", visibleCheck = "ShowFocalRange", minValue = 0f, maxValue = 50f, tooltip = "The length of the range that is 100% in focus")]
		public float m_focalRange;

		// Token: 0x040021B6 RID: 8630
		[Token(Token = "0x40021B6")]
		[FieldOffset(Offset = "0xD4")]
		[Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations.Header(0, "Color Correction")]
		[Field("Mode", useProperty = "colorGradingMode", tooltip = "Which color correction mode is currently active")]
		public ColorGradingMode m_colorGradingMode;

		// Token: 0x040021B7 RID: 8631
		[Token(Token = "0x40021B7")]
		[FieldOffset(Offset = "0xD8")]
		[Field("Compatibility", useProperty = "colorGradingCompatibility", visibleCheck = "ShowCCTex1", tooltip = "Sets the algorithm to be compatible with the lookup textures used by different shaders")]
		public ColorGradingCompatibility m_colorGradingCompatibility;

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		[FieldOffset(Offset = "0xE0")]
		[Field("Lookup Texture", useProperty = "colorGradingTex1", visibleCheck = "ShowCCTex1", tooltip = "The lookup texture used for color correction")]
		public Texture2D m_colorGradingTex1;

		// Token: 0x040021B9 RID: 8633
		[Token(Token = "0x40021B9")]
		[FieldOffset(Offset = "0xE8")]
		[Field("Blend Lookup Texture", useProperty = "colorGradingTex2", visibleCheck = "ShowCCTex2", tooltip = "The lookup texture blended in as the blend factor increases")]
		public Texture2D m_colorGradingTex2;

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0xF0")]
		[Slider("Blend Factor", useProperty = "colorGradingBlendFactor", visibleCheck = "ShowCCTex2", minValue = 0f, maxValue = 1f, tooltip = "Interpolates between the original color correction texture and the blend target color correction texture")]
		public float m_colorGradingBlendFactor;

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0xF4")]
		private bool m_isFirstRender;

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0xF8")]
		private float prevCamFoV;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x100")]
		private Camera m_camera;

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x108")]
		private Bloom m_bloomClass;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x110")]
		private VirtualCamera m_virtualCamera;

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x118")]
		private CombinationPass m_combinationPass;

		// Token: 0x040021C1 RID: 8641
		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0x120")]
		private Downsampling m_downsampling;

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x128")]
		private DepthOfField m_depthOfFieldClass;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x130")]
		private ColorGrading m_colorGrading;

		// Token: 0x040021C4 RID: 8644
		[Token(Token = "0x40021C4")]
		[FieldOffset(Offset = "0x138")]
		private PostProcessParameters postProcessParams;

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x140")]
		private ScionDebug m_scionDebug;

		// Token: 0x040021C6 RID: 8646
		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x0")]
		public static ScionDebug ActiveDebug;
	}
}
