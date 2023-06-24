using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;

namespace Pathfinding
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public interface IGraphInternals
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004DB RID: 1243
		// (set) Token: 0x060004DC RID: 1244
		[Token(Token = "0x170000EE")]
		string SerializedEditorSettings { [Token(Token = "0x60004DB")] get; [Token(Token = "0x60004DC")] set; }

		// Token: 0x060004DD RID: 1245
		[Token(Token = "0x60004DD")]
		void OnDestroy();

		// Token: 0x060004DE RID: 1246
		[Token(Token = "0x60004DE")]
		void DestroyAllNodes();

		// Token: 0x060004DF RID: 1247
		[Token(Token = "0x60004DF")]
		IEnumerable<Progress> ScanInternal();

		// Token: 0x060004E0 RID: 1248
		[Token(Token = "0x60004E0")]
		void SerializeExtraInfo(GraphSerializationContext ctx);

		// Token: 0x060004E1 RID: 1249
		[Token(Token = "0x60004E1")]
		void DeserializeExtraInfo(GraphSerializationContext ctx);

		// Token: 0x060004E2 RID: 1250
		[Token(Token = "0x60004E2")]
		void PostDeserialization(GraphSerializationContext ctx);

		// Token: 0x060004E3 RID: 1251
		[Token(Token = "0x60004E3")]
		void DeserializeSettingsCompatibility(GraphSerializationContext ctx);
	}
}
