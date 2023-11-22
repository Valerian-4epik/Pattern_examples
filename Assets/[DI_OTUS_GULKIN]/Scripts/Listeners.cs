namespace _DI_OTUS_GULKIN_.Scripts
{
    class Listeners
    {
        public interface IStartGameListener
        {
            void OnStartGame();
        }

        public interface IPauseGameListener
        {
            void OnPauseGame();
        }

        public interface IResumeGameListener
        {
            void OnResumeGame();
        }

        public interface IFinishGameListener
        {
            void OnFinishGame();
        }
    }
}