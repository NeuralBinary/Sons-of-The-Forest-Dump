using System;
using System.Runtime.CompilerServices;
using Endnight.Attributes;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	public class MaterialTween : MonoBehaviour
	{
		// Token: 0x060017CA RID: 6090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x2CB4A90", Offset = "0x2CB3A90", VA = "0x182CB4A90")]
		private void Awake()
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x2CB4C50", Offset = "0x2CB3C50", VA = "0x182CB4C50")]
		private void Update()
		{
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x2CB4BB0", Offset = "0x2CB3BB0", VA = "0x182CB4BB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x2CB4AC0", Offset = "0x2CB3AC0", VA = "0x182CB4AC0")]
		private void CalculateRawOutput(float t)
		{
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x2CB4B60", Offset = "0x2CB3B60", VA = "0x182CB4B60")]
		private float GetRawValue(float t)
		{
			return default(float);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x2CB4B50", Offset = "0x2CB3B50", VA = "0x182CB4B50")]
		private float Cos(float t)
		{
			return default(float);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x2CB4B50", Offset = "0x2CB3B50", VA = "0x182CB4B50")]
		private float Sin(float t)
		{
			return default(float);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x2CB4C30", Offset = "0x2CB3C30", VA = "0x182CB4C30")]
		private float Rand(float t)
		{
			return default(float);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x2CB4C20", Offset = "0x2CB3C20", VA = "0x182CB4C20")]
		private float Perlin(float t)
		{
			return default(float);
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00007548 File Offset: 0x00005748
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000333")]
		public float RawOutput
		{
			[Token(Token = "0x60017D3")]
			[Address(RVA = "0x580890", Offset = "0x57F890", VA = "0x180580890")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60017D4")]
			[Address(RVA = "0x2874C60", Offset = "0x2873C60", VA = "0x182874C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x2CB4DD0", Offset = "0x2CB3DD0", VA = "0x182CB4DD0")]
		public MaterialTween()
		{
		}

		// Token: 0x040016DB RID: 5851
		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0x20")]
		[Header("Raw output")]
		public MaterialTween.FunctionTypes _function;

		// Token: 0x040016DC RID: 5852
		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0x24")]
		public float _filterMin;

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x28")]
		public float _filterMax;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0x2C")]
		public float _amplitude;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0x30")]
		public float _offset;

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0x34")]
		[Header("Timing")]
		public float _frequency;

		// Token: 0x040016E1 RID: 5857
		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0x38")]
		public float _timeOffset;

		// Token: 0x040016E2 RID: 5858
		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0x3C")]
		public bool _randTimeOffset;

		// Token: 0x040016E3 RID: 5859
		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x40")]
		[Space(10f)]
		public MaterialTween.Output[] _output;

		// Token: 0x02000391 RID: 913
		[Token(Token = "0x2000391")]
		public enum PropertyTypes
		{
			// Token: 0x040016E6 RID: 5862
			[Token(Token = "0x40016E6")]
			Color,
			// Token: 0x040016E7 RID: 5863
			[Token(Token = "0x40016E7")]
			Float,
			// Token: 0x040016E8 RID: 5864
			[Token(Token = "0x40016E8")]
			LightIntensity,
			// Token: 0x040016E9 RID: 5865
			[Token(Token = "0x40016E9")]
			Message
		}

		// Token: 0x02000392 RID: 914
		[Token(Token = "0x2000392")]
		public enum FunctionTypes
		{
			// Token: 0x040016EB RID: 5867
			[Token(Token = "0x40016EB")]
			Sin,
			// Token: 0x040016EC RID: 5868
			[Token(Token = "0x40016EC")]
			Cos,
			// Token: 0x040016ED RID: 5869
			[Token(Token = "0x40016ED")]
			Rand01,
			// Token: 0x040016EE RID: 5870
			[Token(Token = "0x40016EE")]
			Perlin
		}

		// Token: 0x02000393 RID: 915
		[Token(Token = "0x2000393")]
		public enum ColorFields
		{
			// Token: 0x040016F0 RID: 5872
			[Token(Token = "0x40016F0")]
			R,
			// Token: 0x040016F1 RID: 5873
			[Token(Token = "0x40016F1")]
			G,
			// Token: 0x040016F2 RID: 5874
			[Token(Token = "0x40016F2")]
			B,
			// Token: 0x040016F3 RID: 5875
			[Token(Token = "0x40016F3")]
			A
		}

		// Token: 0x02000394 RID: 916
		[Token(Token = "0x2000394")]
		[Serializable]
		public class Output
		{
			// Token: 0x060017D6 RID: 6102 RVA: 0x00007560 File Offset: 0x00005760
			[Token(Token = "0x60017D6")]
			[Address(RVA = "0x2CD1210", Offset = "0x2CD0210", VA = "0x182CD1210")]
			public float Filter(float value)
			{
				return default(float);
			}

			// Token: 0x060017D7 RID: 6103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017D7")]
			[Address(RVA = "0x2CD1470", Offset = "0x2CD0470", VA = "0x182CD1470")]
			public void MaterialSetFloat()
			{
			}

			// Token: 0x060017D8 RID: 6104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017D8")]
			[Address(RVA = "0x2CD1230", Offset = "0x2CD0230", VA = "0x182CD1230")]
			public void MaterialSetColor()
			{
			}

			// Token: 0x060017D9 RID: 6105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017D9")]
			[Address(RVA = "0x2CD1640", Offset = "0x2CD0640", VA = "0x182CD1640")]
			public void SetLightIntensity()
			{
			}

			// Token: 0x060017DA RID: 6106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017DA")]
			[Address(RVA = "0x2CD15B0", Offset = "0x2CD05B0", VA = "0x182CD15B0")]
			public void SendMessage()
			{
			}

			// Token: 0x060017DB RID: 6107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017DB")]
			[Address(RVA = "0x2CD11D0", Offset = "0x2CD01D0", VA = "0x182CD11D0")]
			public void Clear()
			{
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x060017DC RID: 6108 RVA: 0x00007578 File Offset: 0x00005778
			// (set) Token: 0x060017DD RID: 6109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000334")]
			public float Value
			{
				[Token(Token = "0x60017DC")]
				[Address(RVA = "0x20480A0", Offset = "0x20470A0", VA = "0x1820480A0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60017DD")]
				[Address(RVA = "0x29DD8C0", Offset = "0x29DC8C0", VA = "0x1829DD8C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017DE")]
			[Address(RVA = "0x2CD16E0", Offset = "0x2CD06E0", VA = "0x182CD16E0")]
			public Output()
			{
			}

			// Token: 0x040016F4 RID: 5876
			[Token(Token = "0x40016F4")]
			[FieldOffset(Offset = "0x10")]
			public Component _target;

			// Token: 0x040016F5 RID: 5877
			[Token(Token = "0x40016F5")]
			[FieldOffset(Offset = "0x18")]
			public MaterialTween.PropertyTypes _type;

			// Token: 0x040016F6 RID: 5878
			[Token(Token = "0x40016F6")]
			[FieldOffset(Offset = "0x1C")]
			[Header("Output value")]
			public float _amplitude;

			// Token: 0x040016F7 RID: 5879
			[Token(Token = "0x40016F7")]
			[FieldOffset(Offset = "0x20")]
			public float _offset;

			// Token: 0x040016F8 RID: 5880
			[Token(Token = "0x40016F8")]
			[FieldOffset(Offset = "0x28")]
			[Header("Type: Float")]
			public string _property;

			// Token: 0x040016F9 RID: 5881
			[Token(Token = "0x40016F9")]
			[FieldOffset(Offset = "0x30")]
			[NameFromEnumIndex(typeof(MaterialTween.ColorFields))]
			[Header("Type: Color")]
			public bool[] _colorFields;

			// Token: 0x040016FA RID: 5882
			[Token(Token = "0x40016FA")]
			[FieldOffset(Offset = "0x38")]
			public Color _startColor;

			// Token: 0x040016FB RID: 5883
			[Token(Token = "0x40016FB")]
			[FieldOffset(Offset = "0x48")]
			[Header("Type: Message")]
			public string _message;

			// Token: 0x040016FC RID: 5884
			[Token(Token = "0x40016FC")]
			[FieldOffset(Offset = "0x50")]
			private MaterialPropertyBlock _block;
		}
	}
}
