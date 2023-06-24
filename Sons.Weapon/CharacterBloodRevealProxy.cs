using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[AddComponentMenu("Sons/Weapon/CharacterBloodRevealProxy")]
	public class CharacterBloodRevealProxy : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3193EC0", Offset = "0x31924C0", VA = "0x183193EC0")]
		private void Start()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x3193FE0", Offset = "0x31925E0", VA = "0x183193FE0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3194240", Offset = "0x3192840", VA = "0x183194240")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3194380", Offset = "0x3192980", VA = "0x183194380")]
		private void InitMaterials()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3194600", Offset = "0x3192C00", VA = "0x183194600")]
		public void OnVariationChanged()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3194610", Offset = "0x3192C10", VA = "0x183194610")]
		public static Material GetMaterialInstanceWithIndex(int materialIndex, Renderer targetRenderer, string nameSuffix, out bool existingInstance)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x3194860", Offset = "0x3192E60", VA = "0x183194860", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x31948E0", Offset = "0x3192EE0", VA = "0x1831948E0")]
		private CharacterBloodRevealProxy.BloodArea GetSectionOrDefault(string senderId)
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x3194BA0", Offset = "0x31931A0", VA = "0x183194BA0")]
		public void ApplyBlood(string sourceName)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x3194C00", Offset = "0x3193200", VA = "0x183194C00")]
		public void ApplyBloodMask(int mask)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x3194D00", Offset = "0x3193300", VA = "0x183194D00")]
		public void ApplyBloodToAllSections(float delta)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x3194EC0", Offset = "0x31934C0", VA = "0x183194EC0")]
		public void CleanBlood(float delta)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x3195090", Offset = "0x3193690", VA = "0x183195090")]
		public int GetBloodMask()
		{
			return 0;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x3195150", Offset = "0x3193750", VA = "0x183195150")]
		public int RandomBloodMask()
		{
			return 0;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x3195220", Offset = "0x3193820", VA = "0x183195220")]
		public float GetBloodinessPercentage()
		{
			return 0f;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x31952D0", Offset = "0x31938D0", VA = "0x1831952D0")]
		private void OnMinWetnessChanged()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x3195300", Offset = "0x3193900", VA = "0x183195300")]
		private void OnMinWetnessDefaultChanged()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x3195330", Offset = "0x3193930", VA = "0x183195330")]
		public void SetInCave(bool inCave)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x3195340", Offset = "0x3193940", VA = "0x183195340")]
		public void UpdateMinWetness(bool inCave)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x31954B0", Offset = "0x3193AB0", VA = "0x1831954B0")]
		public void SetCurrentWetness(float wetness, bool inCave)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2AC81B0", Offset = "0x2AC67B0", VA = "0x182AC81B0")]
		private static bool StartsWith(string senderId, string search)
		{
			return default(bool);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x3195570", Offset = "0x3193B70", VA = "0x183195570")]
		private void InstanceMaterials()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x31956B0", Offset = "0x3193CB0", VA = "0x1831956B0")]
		private bool HasInstanceMaterials()
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x3195800", Offset = "0x3193E00", VA = "0x183195800")]
		private void RestoreMaterials()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x3195940", Offset = "0x3193F40", VA = "0x183195940")]
		private void AddDefaultSections()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x3195CA0", Offset = "0x31942A0", VA = "0x183195CA0")]
		public CharacterBloodRevealProxy()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600008B")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		private const string ArmId = "arm/";

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		private const string LegId = "leg/";

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		private const string RightId = "right/";

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		private const string LeftId = "left/";

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		private const string HeadId = "head";

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		private const string RightArmId = "arm/right/";

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		private const string LeftArmId = "arm/left/";

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		private const string RightLegId = "leg/right/";

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		private const string LeftLegId = "leg/left/";

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageController _damageController;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int RedChannelProp;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int GreenChannelProp;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int BlueChannelProp;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int AlphaChannelProp;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int MinWetnessProp;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _bloodPerHit;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<CharacterBloodRevealProxy.BloodArea> _bloodSections;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _inCaveMinWetness;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _defaultWetness;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _maxActorWetness;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _currentWetness;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _bloodMask;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _bloodMaskDirty;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		public enum MaskChannels
		{
			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			Red,
			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			Green,
			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			Blue,
			// Token: 0x04000067 RID: 103
			[Token(Token = "0x4000067")]
			Alpha
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		[Serializable]
		private class BloodRenderSection
		{
			// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
			public BloodRenderSection([Optional] Renderer renderer, int sectionIdx = 0)
			{
			}

			// Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x3195FC0", Offset = "0x31945C0", VA = "0x183195FC0")]
			public void InitMaterial(CharacterBloodRevealProxy.MaskChannels maskChannel)
			{
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x31962B0", Offset = "0x31948B0", VA = "0x1831962B0")]
			public void UpdateMaterial(int shaderPropertyId, float value)
			{
			}

			// Token: 0x0600008F RID: 143 RVA: 0x0000227C File Offset: 0x0000047C
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x31963A0", Offset = "0x31949A0", VA = "0x1831963A0")]
			public bool HasInstanceMaterial()
			{
				return default(bool);
			}

			// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x3196460", Offset = "0x3194A60", VA = "0x183196460")]
			public void RestoreSharedMaterials()
			{
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x3196670", Offset = "0x3194C70", VA = "0x183196670")]
			public void OnDestroy()
			{
			}

			// Token: 0x04000068 RID: 104
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Renderer _renderer;

			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int _sectionIdx;

			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Material _materialInstance;

			// Token: 0x0400006B RID: 107
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool _existingMaterialInstance;

			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Material _oldMaterial;
		}

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		[Serializable]
		internal class BloodArea
		{
			// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x31967B0", Offset = "0x3194DB0", VA = "0x1831967B0")]
			public BloodArea()
			{
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x3196810", Offset = "0x3194E10", VA = "0x183196810")]
			public BloodArea(CharacterBloodRevealProxy.MaskChannels maskChannel, string partId, Renderer renderer, int sectionIdx = 0)
			{
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x3196A90", Offset = "0x3195090", VA = "0x183196A90")]
			public void UpdateMaterial()
			{
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x3196D10", Offset = "0x3195310", VA = "0x183196D10")]
			public void RestoreSharedMaterials()
			{
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002294 File Offset: 0x00000494
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x3196E60", Offset = "0x3195460", VA = "0x183196E60")]
			public bool MatchesPart(string partIdParam)
			{
				return default(bool);
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000097 RID: 151 RVA: 0x000022AC File Offset: 0x000004AC
			[Token(Token = "0x17000023")]
			public bool IsDefault
			{
				[Token(Token = "0x6000097")]
				[Address(RVA = "0x3197010", Offset = "0x3195610", VA = "0x183197010")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x3197090", Offset = "0x3195690", VA = "0x183197090")]
			public void SetValue(float newValue)
			{
			}

			// Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x31970A0", Offset = "0x31956A0", VA = "0x1831970A0")]
			public void InitMaterial()
			{
			}

			// Token: 0x0600009A RID: 154 RVA: 0x000022C4 File Offset: 0x000004C4
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x31971E0", Offset = "0x31957E0", VA = "0x1831971E0")]
			public bool HasInstanceMaterials()
			{
				return default(bool);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x000022DC File Offset: 0x000004DC
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x31973D0", Offset = "0x31959D0", VA = "0x1831973D0")]
			private static int GetPropertyId(CharacterBloodRevealProxy.MaskChannels maskChannel)
			{
				return 0;
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x0600009C RID: 156 RVA: 0x000022F4 File Offset: 0x000004F4
			[Token(Token = "0x17000024")]
			public float CurrentValue
			{
				[Token(Token = "0x600009C")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x3197510", Offset = "0x3195B10", VA = "0x183197510")]
			public void OnDestroy()
			{
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x31977B0", Offset = "0x3195DB0", VA = "0x1831977B0")]
			public void AddValue(float addValue)
			{
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x31977F0", Offset = "0x3195DF0", VA = "0x1831977F0")]
			public void SetMinWetness(float minWetness)
			{
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x3197990", Offset = "0x3195F90", VA = "0x183197990")]
			public void OnValidate(Renderer defaultRenderer)
			{
			}

			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[FormerlySerializedAs("partId")]
			[SerializeField]
			private string _partId;

			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[FormerlySerializedAs("maskChannel")]
			private CharacterBloodRevealProxy.MaskChannels _maskChannel;

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[FormerlySerializedAs("sectionIdx")]
			[SerializeField]
			private int _sectionIdx;

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _bloodPerHitMult;

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			[FormerlySerializedAs("value")]
			[SerializeField]
			private float _value;

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private List<CharacterBloodRevealProxy.BloodRenderSection> _renderSections;
		}
	}
}
