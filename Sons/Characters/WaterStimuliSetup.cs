using System;
using System.Collections.Generic;
using Endnight.Environment;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Characters
{
	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	[AddComponentMenu("Sons/Characters/WaterStimuliSetup")]
	public class WaterStimuliSetup : MonoBehaviour
	{
		// Token: 0x06003176 RID: 12662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003176")]
		[Address(RVA = "0x348B3D0", Offset = "0x34899D0", VA = "0x18348B3D0")]
		private void LoadPerimeter()
		{
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003177")]
		[Address(RVA = "0x348B860", Offset = "0x3489E60", VA = "0x18348B860")]
		private void LoadStreamPerimeter()
		{
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003178")]
		[Address(RVA = "0x348BD90", Offset = "0x348A390", VA = "0x18348BD90")]
		private static HoudiniDetailData GetDataFromTextAsset(TextAsset textAsset)
		{
			return null;
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003179")]
		[Address(RVA = "0x348BEC0", Offset = "0x348A4C0", VA = "0x18348BEC0")]
		public void Init(string waterName, TextAsset perimeterCurve, bool isStream, Bounds bounds)
		{
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317A")]
		[Address(RVA = "0x348BFB0", Offset = "0x348A5B0", VA = "0x18348BFB0")]
		public WaterStimuliSetup()
		{
		}

		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxNavMeshDistance;

		// Token: 0x04002AAA RID: 10922
		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxNavDistanceY;

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minSpacing;

		// Token: 0x04002AAC RID: 10924
		[Token(Token = "0x4002AAC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minDepth;

		// Token: 0x04002AAD RID: 10925
		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxDepth;

		// Token: 0x04002AAE RID: 10926
		[Token(Token = "0x4002AAE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _offset;

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("If terrain is above water at offset point, will check further in until max offset.")]
		[SerializeField]
		private float _maxOffset;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_lakeName")]
		private string _waterName;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isStream;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextAsset _jsonPerimeterCurve;

		// Token: 0x04002AB3 RID: 10931
		[Token(Token = "0x4002AB3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Bounds _bounds;

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _waterStimuliPrefab;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x78")]
		private List<Vector3> _pathNodes;

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x80")]
		private float _drawPointRadius;

		// Token: 0x0200073A RID: 1850
		[Token(Token = "0x200073A")]
		[Serializable]
		private class HoudiniPathSegment
		{
			// Token: 0x0600317B RID: 12667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600317B")]
			[Address(RVA = "0x348C030", Offset = "0x348A630", VA = "0x18348C030")]
			public HoudiniPathSegment()
			{
			}

			// Token: 0x04002AB7 RID: 10935
			[Token(Token = "0x4002AB7")]
			[FieldOffset(Offset = "0x10")]
			public List<Vector3> positions;
		}

		// Token: 0x0200073B RID: 1851
		[Token(Token = "0x200073B")]
		[Serializable]
		private class StreamPerimeterData
		{
			// Token: 0x0600317C RID: 12668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600317C")]
			[Address(RVA = "0x348C0E0", Offset = "0x348A6E0", VA = "0x18348C0E0")]
			public StreamPerimeterData()
			{
			}

			// Token: 0x04002AB8 RID: 10936
			[Token(Token = "0x4002AB8")]
			[FieldOffset(Offset = "0x10")]
			public List<WaterStimuliSetup.HoudiniPathSegment> segments;
		}
	}
}
