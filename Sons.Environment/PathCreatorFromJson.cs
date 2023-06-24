using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[AddComponentMenu("Sons/Environment/Path Creator From JSON")]
	public class PathCreatorFromJson : MonoBehaviour
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetPathCreator(PathCreator pathCreator)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetJsonDataPath(string dataPath)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void ProcessJsonSource()
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2F96B20", Offset = "0x2F95120", VA = "0x182F96B20")]
		public void ProcessJsonSource(List<Vector3> jsonPositions)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2F96BD0", Offset = "0x2F951D0", VA = "0x182F96BD0")]
		private static bool TryGetJsonSourcePath(out string newPath)
		{
			return default(bool);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
		private List<Vector3> GetJsonPositions(string textDataPath)
		{
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PathCreatorFromJson()
		{
		}

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_jsonPathData")]
		[Header("Json Source")]
		private string _jsonDataPath;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PathCreator _pathCreator;
	}
}
