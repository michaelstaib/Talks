                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Session is null && other.Session is null) || Session != null && Session.Equals(other.Session)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                if (!(Session is null))
                {
                    hash ^= 397 * Session.GetHashCode();
                }

                return hash;
            }
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSession_RenameSession_Session_Session : global::System.IEquatable<RenameSession_RenameSession_Session_Session>, IRenameSession_RenameSession_Session_Session
    {
        public RenameSession_RenameSession_Session_Session(global::System.String? @abstract)
        {
            Abstract = @abstract;
        }

        public global::System.String? Abstract { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((RenameSession_RenameSession_Session_Session)obj);
        }

        public global::System.Boolean Equals(RenameSession_RenameSession_Session_Session? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Abstract is null && other.Abstract is null) || Abstract != null && Abstract.Equals(other.Abstract)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                if (!(Abstract is null))
                {
                    hash ^= 397 * Abstract.GetHashCode();
                }

                return hash;
            }
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IRenameSessionResult
    {
        public global::Demo.GraphQL.IRenameSession_RenameSession RenameSession { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IRenameSession_RenameSession
    {
        public global::Demo.GraphQL.IRenameSession_RenameSession_Session? Session { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IRenameSession_RenameSession_RenameSessionPayload : IRenameSession_RenameSession
    {
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IRenameSession_RenameSession_Session
    {
        public global::System.String? Abstract { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IRenameSession_RenameSession_Session_Session : IRenameSession_RenameSession_Session
    {
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessionsResult : global::System.IEquatable<GetSessionsResult>, IGetSessionsResult
    {
        public GetSessionsResult(global::Demo.GraphQL.IGetSessions_Sessions? sessions)
        {
            Sessions = sessions;
        }

        public global::Demo.GraphQL.IGetSessions_Sessions? Sessions { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSessionsResult)obj);
        }

        public global::System.Boolean Equals(GetSessionsResult? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Sessions is null && other.Sessions is null) || Sessions != null && Sessions.Equals(other.Sessions)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                if (!(Sessions is null))
                {
                    hash ^= 397 * Sessions.GetHashCode();
                }

                return hash;
            }
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultTypeGenerator
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessions_Sessions_SessionConnection : global::System.IEquatable<GetSessions_Sessions_SessionConnection>, IGetSessions_Sessions_SessionConnection
    {
        public GetSessions_Sessions_SessionConnection(global::System.Collections.Generic.IReadOnlyList<global::Demo.GraphQL.IGetSessions_Sessions_Nodes>? nodes)
        {
            Nodes = nodes;
        }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Demo.GraphQL.IGetSessions_Sessions_Nodes>? Nodes { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSessions_Sessions_SessionConnection)obj);
        }

        public global::System.Boolean Equals(GetSessions_Sessions_SessionConnection? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(Nodes, other.Nodes));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                if (!(Nodes is null))
                {
                    foreach (var Nodes_elm in Nodes)
                    {
                        hash ^= 397 * Nodes_elm.GetHashCode();
                    }
                }

                return hash;
            }
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessions_Sessions_Nodes_Session : global::System.IEquatable<GetSessions_Sessions_Nodes_Session>, IGetSessions_Sessions_Nodes_Session
    {
        public GetSessions_Sessions_Nodes_Session(global::System.String id, global::System.String title)
        {
            Id = id;
            Title = title;
        }

        public global::System.String Id { get; }

        public global::System.String Title { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSessions_Sessions_Nodes_Session)obj);
        }

        public global::System.Boolean Equals(GetSessions_Sessions_Nodes_Session? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id.Equals(other.Id)) && Title.Equals(other.Title);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Id.GetHashCode();
                hash ^= 397 * Title.GetHashCode();
                return hash;
            }
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetSessionsResult
    {
        public global::Demo.GraphQL.IGetSessions_Sessions? Sessions { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetSessions_Sessions
    {
        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Demo.GraphQL.IGetSessions_Sessions_Nodes>? Nodes { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetSessions_Sessions_SessionConnection : IGetSessions_Sessions
    {
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetSessions_Sessions_Nodes : ISessionInfo
    {
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInterfaceGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetSessions_Sessions_Nodes_Session : IGetSessions_Sessions_Nodes
    {
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.InputValueFormatterGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSessionInputInputValueFormatter : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _iDFormatter = default !;
        private global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter = default !;
        public global::System.String TypeName => "RenameSessionInput";
        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _iDFormatter = serializerResolver.GetInputValueFormatter("ID");
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is RenameSessionInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[]{new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("sessionId", FormatSessionId(d.SessionId)), new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>("title", FormatTitle(d.Title))};
        }

        private global::System.Object? FormatSessionId(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _iDFormatter.Format(value);
        }

        private global::System.Object? FormatTitle(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.InputTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial record RenameSessionInput
    {
        public global::System.String SessionId { get; init; } = default !;
        public global::System.String Title { get; init; } = default !;
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationDocumentGenerator
    /// <summary>
    /// Represents the operation service of the OnSessionChanged GraphQL operation
    /// <code>
    /// subscription OnSessionChanged {
    ///   onSessionScheduled {
    ///     __typename
    ///     ... SessionInfo
    ///     ... on Session {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment SessionInfo on Session {
    ///   id
    ///   title
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnSessionChangedSubscriptionDocument : global::StrawberryShake.IDocument
    {
        private OnSessionChangedSubscriptionDocument()
        {
        }

        public static OnSessionChangedSubscriptionDocument Instance { get; } = new OnSessionChangedSubscriptionDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Subscription;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x73, 0x75, 0x62, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x4f, 0x6e, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x43, 0x68, 0x61, 0x6e, 0x67, 0x65, 0x64, 0x20, 0x7b, 0x20, 0x6f, 0x6e, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x53, 0x63, 0x68, 0x65, 0x64, 0x75, 0x6c, 0x65, 0x64, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x74, 0x69, 0x74, 0x6c, 0x65, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "4005343c7f33cb4936a2fa68fa6bd8d3f0eecbf1");
        public override global::System.String ToString()
        {
#if NETSTANDARD2_0
        return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
#else
            return global::System.Text.Encoding.UTF8.GetString(Body);
#endif
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceGenerator
    /// <summary>
    /// Represents the operation service of the OnSessionChanged GraphQL operation
    /// <code>
    /// subscription OnSessionChanged {
    ///   onSessionScheduled {
    ///     __typename
    ///     ... SessionInfo
    ///     ... on Session {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment SessionInfo on Session {
    ///   id
    ///   title
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnSessionChangedSubscription : global::Demo.GraphQL.IOnSessionChangedSubscription
    {
        private readonly global::StrawberryShake.IOperationExecutor<IOnSessionChangedResult> _operationExecutor;
        public OnSessionChangedSubscription(global::StrawberryShake.IOperationExecutor<IOnSessionChangedResult> operationExecutor)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IOnSessionChangedResult);
        public global::System.IObservable<global::StrawberryShake.IOperationResult<IOnSessionChangedResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {
            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: OnSessionChangedSubscriptionDocument.Instance.Hash.Value, name: "OnSessionChanged", document: OnSessionChangedSubscriptionDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceInterfaceGenerator
    /// <summary>
    /// Represents the operation service of the OnSessionChanged GraphQL operation
    /// <code>
    /// subscription OnSessionChanged {
    ///   onSessionScheduled {
    ///     __typename
    ///     ... SessionInfo
    ///     ... on Session {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment SessionInfo on Session {
    ///   id
    ///   title
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IOnSessionChangedSubscription : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.IObservable<global::StrawberryShake.IOperationResult<IOnSessionChangedResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationDocumentGenerator
    /// <summary>
    /// Represents the operation service of the RenameSession GraphQL operation
    /// <code>
    /// mutation RenameSession($input: RenameSessionInput!) {
    ///   renameSession(input: $input) {
    ///     __typename
    ///     session {
    ///       __typename
    ///       abstract
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSessionMutationDocument : global::StrawberryShake.IDocument
    {
        private RenameSessionMutationDocument()
        {
        }

        public static RenameSessionMutationDocument Instance { get; } = new RenameSessionMutationDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Mutation;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x6d, 0x75, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x52, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x28, 0x24, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x3a, 0x20, 0x52, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x72, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x28, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x3a, 0x20, 0x24, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x73, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x61, 0x62, 0x73, 0x74, 0x72, 0x61, 0x63, 0x74, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "43e4ce5f112ab27b1187876791ccf4e36543ced8");
        public override global::System.String ToString()
        {
#if NETSTANDARD2_0
        return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
#else
            return global::System.Text.Encoding.UTF8.GetString(Body);
#endif
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceGenerator
    /// <summary>
    /// Represents the operation service of the RenameSession GraphQL operation
    /// <code>
    /// mutation RenameSession($input: RenameSessionInput!) {
    ///   renameSession(input: $input) {
    ///     __typename
    ///     session {
    ///       __typename
    ///       abstract
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSessionMutation : global::Demo.GraphQL.IRenameSessionMutation
    {
        private readonly global::StrawberryShake.IOperationExecutor<IRenameSessionResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _renameSessionInputFormatter;
        public RenameSessionMutation(global::StrawberryShake.IOperationExecutor<IRenameSessionResult> operationExecutor, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _renameSessionInputFormatter = serializerResolver.GetInputValueFormatter("RenameSessionInput");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IRenameSessionResult);
        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IRenameSessionResult>> ExecuteAsync(global::Demo.GraphQL.RenameSessionInput input, global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(input);
            return await _operationExecutor.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IRenameSessionResult>> Watch(global::Demo.GraphQL.RenameSessionInput input, global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(input);
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::Demo.GraphQL.RenameSessionInput input)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();
            variables.Add("input", FormatInput(input));
            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: RenameSessionMutationDocument.Instance.Hash.Value, name: "RenameSession", document: RenameSessionMutationDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default, variables: variables);
        }

        private global::System.Object? FormatInput(global::Demo.GraphQL.RenameSessionInput value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _renameSessionInputFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceInterfaceGenerator
    /// <summary>
    /// Represents the operation service of the RenameSession GraphQL operation
    /// <code>
    /// mutation RenameSession($input: RenameSessionInput!) {
    ///   renameSession(input: $input) {
    ///     __typename
    ///     session {
    ///       __typename
    ///       abstract
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IRenameSessionMutation : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IRenameSessionResult>> ExecuteAsync(global::Demo.GraphQL.RenameSessionInput input, global::System.Threading.CancellationToken cancellationToken = default);
        global::System.IObservable<global::StrawberryShake.IOperationResult<IRenameSessionResult>> Watch(global::Demo.GraphQL.RenameSessionInput input, global::StrawberryShake.ExecutionStrategy? strategy = null);
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationDocumentGenerator
    /// <summary>
    /// Represents the operation service of the GetSessions GraphQL operation
    /// <code>
    /// query GetSessions {
    ///   sessions {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       ... SessionInfo
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment SessionInfo on Session {
    ///   id
    ///   title
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessionsQueryDocument : global::StrawberryShake.IDocument
    {
        private GetSessionsQueryDocument()
        {
        }

        public static GetSessionsQueryDocument Instance { get; } = new GetSessionsQueryDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x73, 0x20, 0x7b, 0x20, 0x73, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6e, 0x6f, 0x64, 0x65, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x49, 0x6e, 0x66, 0x6f, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6f, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x74, 0x69, 0x74, 0x6c, 0x65, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "d7480e32110df21d3893e5bafd30806c4fad7eb3");
        public override global::System.String ToString()
        {
#if NETSTANDARD2_0
        return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
#else
            return global::System.Text.Encoding.UTF8.GetString(Body);
#endif
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceGenerator
    /// <summary>
    /// Represents the operation service of the GetSessions GraphQL operation
    /// <code>
    /// query GetSessions {
    ///   sessions {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       ... SessionInfo
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment SessionInfo on Session {
    ///   id
    ///   title
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessionsQuery : global::Demo.GraphQL.IGetSessionsQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetSessionsResult> _operationExecutor;
        public GetSessionsQuery(global::StrawberryShake.IOperationExecutor<IGetSessionsResult> operationExecutor)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetSessionsResult);
        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSessionsResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();
            return await _operationExecutor.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSessionsResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {
            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: GetSessionsQueryDocument.Instance.Hash.Value, name: "GetSessions", document: GetSessionsQueryDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.OperationServiceInterfaceGenerator
    /// <summary>
    /// Represents the operation service of the GetSessions GraphQL operation
    /// <code>
    /// query GetSessions {
    ///   sessions {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       ... SessionInfo
    ///       ... on Session {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment SessionInfo on Session {
    ///   id
    ///   title
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetSessionsQuery : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSessionsResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default);
        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSessionsResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ClientGenerator
    /// <summary>
    /// Represents the ConferenceClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class ConferenceClient : global::Demo.GraphQL.IConferenceClient
    {
        private readonly global::Demo.GraphQL.IOnSessionChangedSubscription _onSessionChanged;
        private readonly global::Demo.GraphQL.IRenameSessionMutation _renameSession;
        private readonly global::Demo.GraphQL.IGetSessionsQuery _getSessions;
        public ConferenceClient(global::Demo.GraphQL.IOnSessionChangedSubscription onSessionChanged, global::Demo.GraphQL.IRenameSessionMutation renameSession, global::Demo.GraphQL.IGetSessionsQuery getSessions)
        {
            _onSessionChanged = onSessionChanged ?? throw new global::System.ArgumentNullException(nameof(onSessionChanged));
            _renameSession = renameSession ?? throw new global::System.ArgumentNullException(nameof(renameSession));
            _getSessions = getSessions ?? throw new global::System.ArgumentNullException(nameof(getSessions));
        }

        public static global::System.String ClientName => "ConferenceClient";
        public global::Demo.GraphQL.IOnSessionChangedSubscription OnSessionChanged => _onSessionChanged;
        public global::Demo.GraphQL.IRenameSessionMutation RenameSession => _renameSession;
        public global::Demo.GraphQL.IGetSessionsQuery GetSessions => _getSessions;
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ClientInterfaceGenerator
    /// <summary>
    /// Represents the ConferenceClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IConferenceClient
    {
        global::Demo.GraphQL.IOnSessionChangedSubscription OnSessionChanged { get; }

        global::Demo.GraphQL.IRenameSessionMutation RenameSession { get; }

        global::Demo.GraphQL.IGetSessionsQuery GetSessions { get; }
    }
}

namespace Demo.GraphQL.State
{
    // StrawberryShake.CodeGeneration.CSharp.Generators.EntityTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial record SessionEntity
    {
        public SessionEntity(global::System.String id, global::System.String title, global::System.String? @abstract)
        {
            Id = id;
            Title = title;
            Abstract = @abstract;
        }

        public global::System.String Id { get; init; }

        public global::System.String Title { get; init; }

        public global::System.String? Abstract { get; init; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultDataFactoryGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnSessionChangedResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.OnSessionChangedResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, OnSessionChanged_OnSessionScheduled_Session> _onSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper;
        public OnSessionChangedResultFactory(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, OnSessionChanged_OnSessionScheduled_Session> onSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _onSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper = onSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper ?? throw new global::System.ArgumentNullException(nameof(onSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Demo.GraphQL.IOnSessionChangedResult);
        public OnSessionChangedResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is OnSessionChangedResultInfo info)
            {
                return new OnSessionChangedResult(MapNonNullableIOnSessionChanged_OnSessionScheduled(info.OnSessionScheduled, snapshot));
            }

            throw new global::System.ArgumentException("OnSessionChangedResultInfo expected.");
        }

        private global::Demo.GraphQL.IOnSessionChanged_OnSessionScheduled MapNonNullableIOnSessionChanged_OnSessionScheduled(global::StrawberryShake.EntityId entityId, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId.Name.Equals("Session", global::System.StringComparison.Ordinal))
            {
                return _onSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper.Map(snapshot.GetEntity<global::Demo.GraphQL.State.SessionEntity>(entityId) ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInfoGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnSessionChangedResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;
        public OnSessionChangedResultInfo(global::StrawberryShake.EntityId onSessionScheduled, global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds, global::System.UInt64 version)
        {
            OnSessionScheduled = onSessionScheduled;
            _entityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::StrawberryShake.EntityId OnSessionScheduled { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;
        public global::System.UInt64 Version => _version;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new OnSessionChangedResultInfo(OnSessionScheduled, _entityIds, version);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultFromEntityTypeMapperGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper : global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, OnSessionChanged_OnSessionScheduled_Session>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public OnSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public OnSessionChanged_OnSessionScheduled_Session Map(global::Demo.GraphQL.State.SessionEntity entity, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new OnSessionChanged_OnSessionScheduled_Session(entity.Id, entity.Title);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultDataFactoryGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSessionResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.RenameSessionResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, RenameSession_RenameSession_Session_Session> _renameSession_RenameSession_Session_SessionFromSessionEntityMapper;
        public RenameSessionResultFactory(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, RenameSession_RenameSession_Session_Session> renameSession_RenameSession_Session_SessionFromSessionEntityMapper)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _renameSession_RenameSession_Session_SessionFromSessionEntityMapper = renameSession_RenameSession_Session_SessionFromSessionEntityMapper ?? throw new global::System.ArgumentNullException(nameof(renameSession_RenameSession_Session_SessionFromSessionEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Demo.GraphQL.IRenameSessionResult);
        public RenameSessionResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is RenameSessionResultInfo info)
            {
                return new RenameSessionResult(MapNonNullableIRenameSession_RenameSession(info.RenameSession, snapshot));
            }

            throw new global::System.ArgumentException("RenameSessionResultInfo expected.");
        }

        private global::Demo.GraphQL.IRenameSession_RenameSession MapNonNullableIRenameSession_RenameSession(global::Demo.GraphQL.State.RenameSessionPayloadData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IRenameSession_RenameSession returnValue = default !;
            if (data.__typename.Equals("RenameSessionPayload", global::System.StringComparison.Ordinal))
            {
                returnValue = new RenameSession_RenameSession_RenameSessionPayload(MapIRenameSession_RenameSession_Session(data.Session, snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Demo.GraphQL.IRenameSession_RenameSession_Session? MapIRenameSession_RenameSession_Session(global::StrawberryShake.EntityId? entityId, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }

            if (entityId.Value.Name.Equals("Session", global::System.StringComparison.Ordinal))
            {
                return _renameSession_RenameSession_Session_SessionFromSessionEntityMapper.Map(snapshot.GetEntity<global::Demo.GraphQL.State.SessionEntity>(entityId.Value) ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInfoGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSessionResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;
        public RenameSessionResultInfo(global::Demo.GraphQL.State.RenameSessionPayloadData renameSession, global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds, global::System.UInt64 version)
        {
            RenameSession = renameSession;
            _entityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Demo.GraphQL.State.RenameSessionPayloadData RenameSession { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;
        public global::System.UInt64 Version => _version;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new RenameSessionResultInfo(RenameSession, _entityIds, version);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultFromEntityTypeMapperGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSession_RenameSession_Session_SessionFromSessionEntityMapper : global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, RenameSession_RenameSession_Session_Session>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public RenameSession_RenameSession_Session_SessionFromSessionEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public RenameSession_RenameSession_Session_Session Map(global::Demo.GraphQL.State.SessionEntity entity, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new RenameSession_RenameSession_Session_Session(entity.Abstract);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultDataFactoryGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessionsResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.GetSessionsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, GetSessions_Sessions_Nodes_Session> _getSessions_Sessions_Nodes_SessionFromSessionEntityMapper;
        public GetSessionsResultFactory(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, GetSessions_Sessions_Nodes_Session> getSessions_Sessions_Nodes_SessionFromSessionEntityMapper)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getSessions_Sessions_Nodes_SessionFromSessionEntityMapper = getSessions_Sessions_Nodes_SessionFromSessionEntityMapper ?? throw new global::System.ArgumentNullException(nameof(getSessions_Sessions_Nodes_SessionFromSessionEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Demo.GraphQL.IGetSessionsResult);
        public GetSessionsResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetSessionsResultInfo info)
            {
                return new GetSessionsResult(MapIGetSessions_Sessions(info.Sessions, snapshot));
            }

            throw new global::System.ArgumentException("GetSessionsResultInfo expected.");
        }

        private global::Demo.GraphQL.IGetSessions_Sessions? MapIGetSessions_Sessions(global::Demo.GraphQL.State.SessionConnectionData? data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetSessions_Sessions returnValue = default !;
            if (data?.__typename.Equals("SessionConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetSessions_Sessions_SessionConnection(MapIGetSessions_Sessions_NodesNonNullableArray(data.Nodes, snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Demo.GraphQL.IGetSessions_Sessions_Nodes>? MapIGetSessions_Sessions_NodesNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var sessions = new global::System.Collections.Generic.List<global::Demo.GraphQL.IGetSessions_Sessions_Nodes>();
            foreach (global::StrawberryShake.EntityId child in list)
            {
                sessions.Add(MapNonNullableIGetSessions_Sessions_Nodes(child, snapshot));
            }

            return sessions;
        }

        private global::Demo.GraphQL.IGetSessions_Sessions_Nodes MapNonNullableIGetSessions_Sessions_Nodes(global::StrawberryShake.EntityId entityId, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId.Name.Equals("Session", global::System.StringComparison.Ordinal))
            {
                return _getSessions_Sessions_Nodes_SessionFromSessionEntityMapper.Map(snapshot.GetEntity<global::Demo.GraphQL.State.SessionEntity>(entityId) ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultInfoGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessionsResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;
        public GetSessionsResultInfo(global::Demo.GraphQL.State.SessionConnectionData? sessions, global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds, global::System.UInt64 version)
        {
            Sessions = sessions;
            _entityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Demo.GraphQL.State.SessionConnectionData? Sessions { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;
        public global::System.UInt64 Version => _version;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetSessionsResultInfo(Sessions, _entityIds, version);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.ResultFromEntityTypeMapperGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessions_Sessions_Nodes_SessionFromSessionEntityMapper : global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, GetSessions_Sessions_Nodes_Session>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public GetSessions_Sessions_Nodes_SessionFromSessionEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetSessions_Sessions_Nodes_Session Map(global::Demo.GraphQL.State.SessionEntity entity, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetSessions_Sessions_Nodes_Session(entity.Id, entity.Title);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.JsonResultBuilderGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class OnSessionChangedBuilder : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IOnSessionChangedResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IOnSessionChangedResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _iDParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        public OnSessionChangedBuilder(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer idSerializer, global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IOnSessionChangedResult> resultDataFactory, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _iDParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("ID") ?? throw new global::System.ArgumentException("No serializer for type `ID` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String") ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IOnSessionChangedResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IOnSessionChangedResult Result, OnSessionChangedResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;
            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }

                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch (global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(ex.Message, exception: ex)};
            }

            return new global::StrawberryShake.OperationResult<IOnSessionChangedResult>(data?.Result, data?.Info, _resultDataFactory, errors);
        }

        private (IOnSessionChangedResult, OnSessionChangedResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default !;
            global::StrawberryShake.EntityId onSessionScheduledId = default !;
            _entityStore.Update(session =>
            {
                onSessionScheduledId = UpdateNonNullableIOnSessionChanged_OnSessionScheduledEntity(session, global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "onSessionScheduled"), entityIds);
                snapshot = session.CurrentSnapshot;
            });
            var resultInfo = new OnSessionChangedResultInfo(onSessionScheduledId, entityIds, snapshot.Version);
            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIOnSessionChanged_OnSessionScheduledEntity(global::StrawberryShake.IEntityStoreUpdateSession session, global::System.Text.Json.JsonElement? obj, global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);
            if (entityId.Name.Equals("Session", global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(entityId, out global::Demo.GraphQL.State.SessionEntity? entity))
                {
                    session.SetEntity(entityId, new global::Demo.GraphQL.State.SessionEntity(DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "id")), DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "title")), entity.Abstract));
                }
                else
                {
                    session.SetEntity(entityId, new global::Demo.GraphQL.State.SessionEntity(DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "id")), DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "title")), default !));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _iDParser.Parse(obj.Value.GetString()!);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.JsonResultBuilderGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSessionBuilder : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IRenameSessionResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IRenameSessionResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _iDParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        public RenameSessionBuilder(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer idSerializer, global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IRenameSessionResult> resultDataFactory, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _iDParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("ID") ?? throw new global::System.ArgumentException("No serializer for type `ID` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String") ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IRenameSessionResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IRenameSessionResult Result, RenameSessionResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;
            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }

                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch (global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(ex.Message, exception: ex)};
            }

            return new global::StrawberryShake.OperationResult<IRenameSessionResult>(data?.Result, data?.Info, _resultDataFactory, errors);
        }

        private (IRenameSessionResult, RenameSessionResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default !;
            global::Demo.GraphQL.State.RenameSessionPayloadData renameSessionId = default !;
            _entityStore.Update(session =>
            {
                renameSessionId = DeserializeNonNullableIRenameSession_RenameSession(session, global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "renameSession"), entityIds);
                snapshot = session.CurrentSnapshot;
            });
            var resultInfo = new RenameSessionResultInfo(renameSessionId, entityIds, snapshot.Version);
            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::Demo.GraphQL.State.RenameSessionPayloadData DeserializeNonNullableIRenameSession_RenameSession(global::StrawberryShake.IEntityStoreUpdateSession session, global::System.Text.Json.JsonElement? obj, global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var typename = obj.Value.GetProperty("__typename").GetString();
            if (typename?.Equals("RenameSessionPayload", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Demo.GraphQL.State.RenameSessionPayloadData(typename, session: UpdateIRenameSession_RenameSession_SessionEntity(session, global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "session"), entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::StrawberryShake.EntityId? UpdateIRenameSession_RenameSession_SessionEntity(global::StrawberryShake.IEntityStoreUpdateSession session, global::System.Text.Json.JsonElement? obj, global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);
            if (entityId.Name.Equals("Session", global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(entityId, out global::Demo.GraphQL.State.SessionEntity? entity))
                {
                    session.SetEntity(entityId, new global::Demo.GraphQL.State.SessionEntity(entity.Id, entity.Title, DeserializeString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "abstract"))));
                }
                else
                {
                    session.SetEntity(entityId, new global::Demo.GraphQL.State.SessionEntity(default !, default !, DeserializeString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "abstract"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.JsonResultBuilderGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetSessionsBuilder : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IGetSessionsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IGetSessionsResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _iDParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        public GetSessionsBuilder(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer idSerializer, global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IGetSessionsResult> resultDataFactory, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _iDParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("ID") ?? throw new global::System.ArgumentException("No serializer for type `ID` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String") ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetSessionsResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetSessionsResult Result, GetSessionsResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;
            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }

                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch (global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(ex.Message, exception: ex)};
            }

            return new global::StrawberryShake.OperationResult<IGetSessionsResult>(data?.Result, data?.Info, _resultDataFactory, errors);
        }

        private (IGetSessionsResult, GetSessionsResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default !;
            global::Demo.GraphQL.State.SessionConnectionData? sessionsId = default !;
            _entityStore.Update(session =>
            {
                sessionsId = DeserializeIGetSessions_Sessions(session, global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "sessions"), entityIds);
                snapshot = session.CurrentSnapshot;
            });
            var resultInfo = new GetSessionsResultInfo(sessionsId, entityIds, snapshot.Version);
            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::Demo.GraphQL.State.SessionConnectionData? DeserializeIGetSessions_Sessions(global::StrawberryShake.IEntityStoreUpdateSession session, global::System.Text.Json.JsonElement? obj, global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value.GetProperty("__typename").GetString();
            if (typename?.Equals("SessionConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Demo.GraphQL.State.SessionConnectionData(typename, nodes: UpdateIGetSessions_Sessions_NodesEntityNonNullableArray(session, global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "nodes"), entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? UpdateIGetSessions_Sessions_NodesEntityNonNullableArray(global::StrawberryShake.IEntityStoreUpdateSession session, global::System.Text.Json.JsonElement? obj, global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var sessions = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();
            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                sessions.Add(UpdateNonNullableIGetSessions_Sessions_NodesEntity(session, child, entityIds));
            }

            return sessions;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetSessions_Sessions_NodesEntity(global::StrawberryShake.IEntityStoreUpdateSession session, global::System.Text.Json.JsonElement? obj, global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);
            if (entityId.Name.Equals("Session", global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(entityId, out global::Demo.GraphQL.State.SessionEntity? entity))
                {
                    session.SetEntity(entityId, new global::Demo.GraphQL.State.SessionEntity(DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "id")), DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "title")), entity.Abstract));
                }
                else
                {
                    session.SetEntity(entityId, new global::Demo.GraphQL.State.SessionEntity(DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "id")), DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "title")), default !));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _iDParser.Parse(obj.Value.GetString()!);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.DataTypeGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class RenameSessionPayloadData
    {
        public RenameSessionPayloadData(global::System.String __typename, global::StrawberryShake.EntityId? session = null)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Session = session;
        }

        public global::System.String __typename { get; }

        public global::StrawberryShake.EntityId? Session { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.DataTypeGenerator
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SessionConnectionData
    {
        public SessionConnectionData(global::System.String __typename, global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? nodes = null)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Nodes = nodes;
        }

        public global::System.String __typename { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? Nodes { get; }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.EntityIdFactoryGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class ConferenceClientEntityIdFactory : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions()
        {Indented = false};
        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String __typename = obj.GetProperty("__typename").GetString()!;
            return __typename switch
            {
            "Session" => ParseSessionEntityId(obj, __typename), _ => throw new global::System.NotSupportedException()}

            ;
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
            "Session" => FormatSessionEntityId(entityId), _ => throw new global::System.NotSupportedException()}

            ;
        }

        private global::StrawberryShake.EntityId ParseSessionEntityId(global::System.Text.Json.JsonElement obj, global::System.String type)
        {
            return new global::StrawberryShake.EntityId(type, obj.GetProperty("id").GetString()!);
        }

        private global::System.String FormatSessionEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(writer, _options);
            jsonWriter.WriteStartObject();
            jsonWriter.WriteString("__typename", entityId.Name);
            jsonWriter.WriteString("id", (global::System.String)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();
            return global::System.Text.Encoding.UTF8.GetString(writer.GetInternalBuffer(), 0, writer.Length);
        }
    }

    // StrawberryShake.CodeGeneration.CSharp.Generators.StoreAccessorGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class ConferenceClientStoreAccessor : global::StrawberryShake.StoreAccessor
    {
        public ConferenceClientStoreAccessor(global::StrawberryShake.IOperationStore operationStore, global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer entityIdSerializer, global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories, global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories): base(operationStore, entityStore, entityIdSerializer, requestFactories, resultDataFactories)
        {
        }
    }
}

namespace Microsoft.Extensions.DependencyInjection
{
    // StrawberryShake.CodeGeneration.CSharp.Generators.DependencyInjectionGenerator
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public static partial class ConferenceClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::Demo.GraphQL.State.ConferenceClientStoreAccessor> AddConferenceClient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp =>
            {
                var serviceCollection = ConfigureClientDefault(sp, strategy);
                return new ClientServiceProvider(global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => new global::Demo.GraphQL.State.ConferenceClientStoreAccessor(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.OnSessionChangedSubscription>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.RenameSessionMutation>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.GetSessionsQuery>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.ConferenceClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.IConferenceClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            return new global::StrawberryShake.ClientBuilder<global::Demo.GraphQL.State.ConferenceClientStoreAccessor>("ConferenceClient", services);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(global::System.IServiceProvider parentServices, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var services = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(services, sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp =>
            {
                var sessionPool = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.WebSockets.ISessionPool>(parentServices);
                return new global::StrawberryShake.Transport.WebSockets.WebSocketConnection(async ct => await sessionPool.CreateAsync("ConferenceClient", ct));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp =>
            {
                var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("ConferenceClient"));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, global::Demo.GraphQL.OnSessionChanged_OnSessionScheduled_Session>, global::Demo.GraphQL.State.OnSessionChanged_OnSessionScheduled_SessionFromSessionEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, global::Demo.GraphQL.RenameSession_RenameSession_Session_Session>, global::Demo.GraphQL.State.RenameSession_RenameSession_Session_SessionFromSessionEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Demo.GraphQL.State.SessionEntity, global::Demo.GraphQL.GetSessions_Sessions_Nodes_Session>, global::Demo.GraphQL.State.GetSessions_Sessions_Nodes_SessionFromSessionEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Demo.GraphQL.RenameSessionInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(services, sp => new global::StrawberryShake.Serialization.SerializerResolver(global::System.Linq.Enumerable.Concat(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(parentServices), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(sp))));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IOnSessionChangedResult>, global::Demo.GraphQL.State.OnSessionChangedResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IOnSessionChangedResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.IOnSessionChangedSubscription>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IOnSessionChangedResult>, global::Demo.GraphQL.State.OnSessionChangedBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Demo.GraphQL.IOnSessionChangedResult>>(services, sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IOnSessionChangedResult>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.WebSockets.WebSocketConnection>(sp), () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IOnSessionChangedResult>>(sp), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp), strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.OnSessionChangedSubscription>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.IOnSessionChangedSubscription>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.OnSessionChangedSubscription>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IRenameSessionResult>, global::Demo.GraphQL.State.RenameSessionResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IRenameSessionResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.IRenameSessionMutation>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IRenameSessionResult>, global::Demo.GraphQL.State.RenameSessionBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Demo.GraphQL.IRenameSessionResult>>(services, sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IRenameSessionResult>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp), () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IRenameSessionResult>>(sp), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp), strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.RenameSessionMutation>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.IRenameSessionMutation>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.RenameSessionMutation>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IGetSessionsResult>, global::Demo.GraphQL.State.GetSessionsResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Demo.GraphQL.IGetSessionsResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.IGetSessionsQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IGetSessionsResult>, global::Demo.GraphQL.State.GetSessionsBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Demo.GraphQL.IGetSessionsResult>>(services, sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IGetSessionsResult>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp), () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Demo.GraphQL.IGetSessionsResult>>(sp), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp), strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.GetSessionsQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.IGetSessionsQuery>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.GetSessionsQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::Demo.GraphQL.State.ConferenceClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.ConferenceClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Demo.GraphQL.IConferenceClient>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Demo.GraphQL.ConferenceClient>(sp));
            return services;
        }

        private class ClientServiceProvider : System.IServiceProvider, System.IDisposable
        {
            private readonly System.IServiceProvider _provider;
            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


