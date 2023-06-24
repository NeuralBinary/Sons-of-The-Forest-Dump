using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x0200064C RID: 1612
	[Token(Token = "0x200064C")]
	public class AutoConvertSceneToHoudiniData : MonoBehaviour
	{
		// Token: 0x060029B4 RID: 10676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CreateInstances()
		{
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x33F0050", Offset = "0x33EE650", VA = "0x1833F0050")]
		private Transform GetParentTransform(WorldObjectLocatorData asset)
		{
			return null;
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDestroy()
		{
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x33F0210", Offset = "0x33EE810", VA = "0x1833F0210")]
		public AutoConvertSceneToHoudiniData()
		{
		}

		// Token: 0x04002517 RID: 9495
		[Token(Token = "0x4002517")]
		private const string ProxyPrefix = "[proxy]";

		// Token: 0x04002518 RID: 9496
		[Token(Token = "0x4002518")]
		private const string EditorOnlyTag = "EditorOnly";

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x4002519")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _worldGroupId;

		// Token: 0x0400251A RID: 9498
		[Token(Token = "0x400251A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _readOnly;

		// Token: 0x0400251B RID: 9499
		[Token(Token = "0x400251B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _ignoreRoots;

		// Token: 0x0400251C RID: 9500
		[Token(Token = "0x400251C")]
		[FieldOffset(Offset = "0x38")]
		private TextAsset _outputSelector;

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _outputPath;

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[FormerlySerializedAs("_output")]
		[SerializeField]
		private TextAsset _outputBackup;

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _instanceId;

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _managedObjects;

		// Token: 0x04002521 RID: 9505
		[Token(Token = "0x4002521")]
		[FieldOffset(Offset = "0x60")]
		private bool _limitToChildren;

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x64")]
		private Scene _myScene;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x68")]
		private DateTime _lastHierarchyChanged;

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0x70")]
		private TextAsset _cachedOutputSelector;

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float _duplicateThreshold;

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x78")]
		private List<GameObject> _delayRemovedManaged;
	}
}
