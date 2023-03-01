using System;
using System.Collections.Generic;
using Endnight.Environment;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Characters
{
	// Token: 0x02000826 RID: 2086
	[Token(Token = "0x2000826")]
	[AddComponentMenu("Sons/Characters/WaterStimuliSetup")]
	public class WaterStimuliSetup : MonoBehaviour
	{
		// Token: 0x06003792 RID: 14226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003792")]
		[Address(RVA = "0x2EC51B0", Offset = "0x2EC41B0", VA = "0x182EC51B0")]
		private void LoadPerimeter()
		{
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003793")]
		[Address(RVA = "0x2EC5550", Offset = "0x2EC4550", VA = "0x182EC5550")]
		private void LoadStreamPerimeter()
		{
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003794")]
		[Address(RVA = "0x2EC5060", Offset = "0x2EC4060", VA = "0x182EC5060")]
		private static HoudiniDetailData GetDataFromTextAsset(TextAsset textAsset)
		{
			return null;
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003795")]
		[Address(RVA = "0x2EC5140", Offset = "0x2EC4140", VA = "0x182EC5140")]
		public void Init(string waterName, TextAsset perimeterCurve, bool isStream, Bounds bounds)
		{
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003796")]
		[Address(RVA = "0x2EC5940", Offset = "0x2EC4940", VA = "0x182EC5940")]
		public WaterStimuliSetup()
		{
		}

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxNavMeshDistance;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxNavDistanceY;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minSpacing;

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minDepth;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxDepth;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _offset;

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("If terrain is above water at offset point, will check further in until max offset.")]
		[SerializeField]
		private float _maxOffset;

		// Token: 0x04002F94 RID: 12180
		[Token(Token = "0x4002F94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_lakeName")]
		private string _waterName;

		// Token: 0x04002F95 RID: 12181
		[Token(Token = "0x4002F95")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isStream;

		// Token: 0x04002F96 RID: 12182
		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextAsset _jsonPerimeterCurve;

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Bounds _bounds;

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _waterStimuliPrefab;

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		[FieldOffset(Offset = "0x78")]
		private List<Vector3> _pathNodes;

		// Token: 0x04002F9A RID: 12186
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0x80")]
		private float _drawPointRadius;

		// Token: 0x02000827 RID: 2087
		[Token(Token = "0x2000827")]
		[Serializable]
		private class HoudiniPathSegment
		{
			// Token: 0x06003797 RID: 14231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003797")]
			[Address(RVA = "0x2EB7E00", Offset = "0x2EB6E00", VA = "0x182EB7E00")]
			public HoudiniPathSegment()
			{
			}

			// Token: 0x04002F9B RID: 12187
			[Token(Token = "0x4002F9B")]
			[FieldOffset(Offset = "0x10")]
			public List<Vector3> positions;
		}

		// Token: 0x02000828 RID: 2088
		[Token(Token = "0x2000828")]
		[Serializable]
		private class StreamPerimeterData
		{
			// Token: 0x06003798 RID: 14232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003798")]
			[Address(RVA = "0x2EB9DC0", Offset = "0x2EB8DC0", VA = "0x182EB9DC0")]
			public StreamPerimeterData()
			{
			}

			// Token: 0x04002F9C RID: 12188
			[Token(Token = "0x4002F9C")]
			[FieldOffset(Offset = "0x10")]
			public List<WaterStimuliSetup.HoudiniPathSegment> segments;
		}
	}
}
