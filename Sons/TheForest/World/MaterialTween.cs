using System;
using System.Runtime.CompilerServices;
using Endnight.Attributes;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	public class MaterialTween : MonoBehaviour
	{
		// Token: 0x06001805 RID: 6149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001805")]
		[Address(RVA = "0x3278310", Offset = "0x3276910", VA = "0x183278310")]
		private void Awake()
		{
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x3278380", Offset = "0x3276980", VA = "0x183278380")]
		private void Update()
		{
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001807")]
		[Address(RVA = "0x3278550", Offset = "0x3276B50", VA = "0x183278550")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001808")]
		[Address(RVA = "0x32786C0", Offset = "0x3276CC0", VA = "0x1832786C0")]
		private void CalculateRawOutput(float t)
		{
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x3278780", Offset = "0x3276D80", VA = "0x183278780")]
		private float GetRawValue(float t)
		{
			return 0f;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x3278810", Offset = "0x3276E10", VA = "0x183278810")]
		private float Cos(float t)
		{
			return 0f;
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x3278810", Offset = "0x3276E10", VA = "0x183278810")]
		private float Sin(float t)
		{
			return 0f;
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x3278820", Offset = "0x3276E20", VA = "0x183278820")]
		private float Rand(float t)
		{
			return 0f;
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x3278880", Offset = "0x3276E80", VA = "0x183278880")]
		private float Perlin(float t)
		{
			return 0f;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x000077B8 File Offset: 0x000059B8
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033B")]
		public float RawOutput
		{
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x2D635A0", Offset = "0x2D61BA0", VA = "0x182D635A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x3278890", Offset = "0x3276E90", VA = "0x183278890")]
		public MaterialTween()
		{
		}

		// Token: 0x040016FA RID: 5882
		[Token(Token = "0x40016FA")]
		[FieldOffset(Offset = "0x20")]
		[Header("Raw output")]
		public MaterialTween.FunctionTypes _function;

		// Token: 0x040016FB RID: 5883
		[Token(Token = "0x40016FB")]
		[FieldOffset(Offset = "0x24")]
		public float _filterMin;

		// Token: 0x040016FC RID: 5884
		[Token(Token = "0x40016FC")]
		[FieldOffset(Offset = "0x28")]
		public float _filterMax;

		// Token: 0x040016FD RID: 5885
		[Token(Token = "0x40016FD")]
		[FieldOffset(Offset = "0x2C")]
		public float _amplitude;

		// Token: 0x040016FE RID: 5886
		[Token(Token = "0x40016FE")]
		[FieldOffset(Offset = "0x30")]
		public float _offset;

		// Token: 0x040016FF RID: 5887
		[Token(Token = "0x40016FF")]
		[FieldOffset(Offset = "0x34")]
		[Header("Timing")]
		public float _frequency;

		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		[FieldOffset(Offset = "0x38")]
		public float _timeOffset;

		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x4001701")]
		[FieldOffset(Offset = "0x3C")]
		public bool _randTimeOffset;

		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		[FieldOffset(Offset = "0x40")]
		[Space(10f)]
		public MaterialTween.Output[] _output;

		// Token: 0x02000383 RID: 899
		[Token(Token = "0x2000383")]
		public enum PropertyTypes
		{
			// Token: 0x04001705 RID: 5893
			[Token(Token = "0x4001705")]
			Color,
			// Token: 0x04001706 RID: 5894
			[Token(Token = "0x4001706")]
			Float,
			// Token: 0x04001707 RID: 5895
			[Token(Token = "0x4001707")]
			LightIntensity,
			// Token: 0x04001708 RID: 5896
			[Token(Token = "0x4001708")]
			Message
		}

		// Token: 0x02000384 RID: 900
		[Token(Token = "0x2000384")]
		public enum FunctionTypes
		{
			// Token: 0x0400170A RID: 5898
			[Token(Token = "0x400170A")]
			Sin,
			// Token: 0x0400170B RID: 5899
			[Token(Token = "0x400170B")]
			Cos,
			// Token: 0x0400170C RID: 5900
			[Token(Token = "0x400170C")]
			Rand01,
			// Token: 0x0400170D RID: 5901
			[Token(Token = "0x400170D")]
			Perlin
		}

		// Token: 0x02000385 RID: 901
		[Token(Token = "0x2000385")]
		public enum ColorFields
		{
			// Token: 0x0400170F RID: 5903
			[Token(Token = "0x400170F")]
			R,
			// Token: 0x04001710 RID: 5904
			[Token(Token = "0x4001710")]
			G,
			// Token: 0x04001711 RID: 5905
			[Token(Token = "0x4001711")]
			B,
			// Token: 0x04001712 RID: 5906
			[Token(Token = "0x4001712")]
			A
		}

		// Token: 0x02000386 RID: 902
		[Token(Token = "0x2000386")]
		[Serializable]
		public class Output
		{
			// Token: 0x06001811 RID: 6161 RVA: 0x000077D0 File Offset: 0x000059D0
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x32788F0", Offset = "0x3276EF0", VA = "0x1832788F0")]
			public float Filter(float value)
			{
				return 0f;
			}

			// Token: 0x06001812 RID: 6162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x3278910", Offset = "0x3276F10", VA = "0x183278910")]
			public void MaterialSetFloat()
			{
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x3278B50", Offset = "0x3277150", VA = "0x183278B50")]
			public void MaterialSetColor()
			{
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x3278E90", Offset = "0x3277490", VA = "0x183278E90")]
			public void SetLightIntensity()
			{
			}

			// Token: 0x06001815 RID: 6165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x3278F80", Offset = "0x3277580", VA = "0x183278F80")]
			public void SendMessage()
			{
			}

			// Token: 0x06001816 RID: 6166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001816")]
			[Address(RVA = "0x3279010", Offset = "0x3277610", VA = "0x183279010")]
			public void Clear()
			{
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x06001817 RID: 6167 RVA: 0x000077E8 File Offset: 0x000059E8
			// (set) Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700033C")]
			public float Value
			{
				[Token(Token = "0x6001817")]
				[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6001818")]
				[Address(RVA = "0x2FBB2B0", Offset = "0x2FB98B0", VA = "0x182FBB2B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06001819 RID: 6169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x32790C0", Offset = "0x32776C0", VA = "0x1832790C0")]
			public Output()
			{
			}

			// Token: 0x04001713 RID: 5907
			[Token(Token = "0x4001713")]
			[FieldOffset(Offset = "0x10")]
			public Component _target;

			// Token: 0x04001714 RID: 5908
			[Token(Token = "0x4001714")]
			[FieldOffset(Offset = "0x18")]
			public MaterialTween.PropertyTypes _type;

			// Token: 0x04001715 RID: 5909
			[Token(Token = "0x4001715")]
			[FieldOffset(Offset = "0x1C")]
			[Header("Output value")]
			public float _amplitude;

			// Token: 0x04001716 RID: 5910
			[Token(Token = "0x4001716")]
			[FieldOffset(Offset = "0x20")]
			public float _offset;

			// Token: 0x04001717 RID: 5911
			[Token(Token = "0x4001717")]
			[FieldOffset(Offset = "0x28")]
			[Header("Type: Float")]
			public string _property;

			// Token: 0x04001718 RID: 5912
			[Token(Token = "0x4001718")]
			[FieldOffset(Offset = "0x30")]
			[Header("Type: Color")]
			[NameFromEnumIndex(typeof(MaterialTween.ColorFields))]
			public bool[] _colorFields;

			// Token: 0x04001719 RID: 5913
			[Token(Token = "0x4001719")]
			[FieldOffset(Offset = "0x38")]
			public Color _startColor;

			// Token: 0x0400171A RID: 5914
			[Token(Token = "0x400171A")]
			[FieldOffset(Offset = "0x48")]
			[Header("Type: Message")]
			public string _message;

			// Token: 0x0400171B RID: 5915
			[Token(Token = "0x400171B")]
			[FieldOffset(Offset = "0x50")]
			private MaterialPropertyBlock _block;
		}
	}
}
