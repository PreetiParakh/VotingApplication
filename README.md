# VotingApplication

**Voting App ASP.NET Web API README**

**Description:**
The Voting App ASP.NET Web API project serves as the backend service for a voting application. It provides endpoints for adding candidates, casting votes, and retrieving voting results. This project is designed to be consumed by frontend applications such as web or mobile clients.

**Features:**
1. **Candidate Management**: API endpoints to add and retrieve candidate information.
2. **Voter Management**: API endpoints to add and retrieve voter information.
3. **Voting**: Endpoints for users to cast their votes.

**Prerequisites:**
- .NET Core SDK installed on the system.
- Visual Studio 2022 or any other IDE for development.

**Installation:**
1. Clone the repository from GitHub Repo URL.
2. Open the solution file (.sln) in Visual Studio.
3. Build the solution to ensure all dependencies are resolved.
4. Run the application.

**API Endpoints:**
- **GET /api/Candidates**: Retrieves the list of candidates.
- **POST /api/Candidates**: Adds a new candidate.
- **GET /api/Voters**: Retrieves the list of voters.
- **POST /api/Voters**: Adds a new voter.
- **POST /api/VoteCandidates/vote/{voterId}/{candidateId}**: Retrieves voting results.

**Contributing:**
Contributions to the project are welcome. If you have any suggestions, improvements, or bug fixes, feel free to submit a pull request.

**Author:**
Preeti Parakh
